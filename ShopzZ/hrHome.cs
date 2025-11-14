using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AmaZon
{
    public partial class hrHome : Form
    {
        public hrHome()
        {
            InitializeComponent();
            hrinfo();
            adminlist();
            profile_panel.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;

        }

        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }

        public string hrpass = "";
        public int hid = 0;

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void hrHome_Load(object sender, EventArgs e)
        {
            hrinfo();
        }

        public void hrinfo()
        {
            try
            {
                DBconnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HRTABLE WHERE HID_number = @hid", connection);
                cmd.Parameters.AddWithValue("@hid", hid);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hridbox.Text = dr.GetValue(1).ToString();
                    hrnamebox.Text = dr.GetValue(2).ToString();
                    hrmailbox.Text = dr.GetValue(3).ToString();
                    hrcountrybox.Text = dr.GetValue(5).ToString();
                    hrcitybox.Text = dr.GetValue(6).ToString();
                    hrphnbox.Text = dr.GetValue(8).ToString ();
                    hrgenderbox.Text = dr.GetValue(4).ToString();
                    hrpass = dr.GetValue(7).ToString();
                    hradressbox.Text = dr.GetValue(6).ToString() + ", " + dr.GetValue(5).ToString();
                }

            }
            catch
            {
                MessageBox.Show("Error in HR Info");
            }
            finally
            {
                connection.Close();
            }

        }



        private void admin_info_button_Click(object sender, EventArgs e)
        {
            profile_panel.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void addAdmin_button_Click(object sender, EventArgs e)
        {
            profile_panel.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void addHR_button_Click(object sender, EventArgs e)
        {
            profile_panel.Visible = false;
            panel1.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void AdminInfo_panel_Click(object sender, EventArgs e)
        {
            profile_panel.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;

            adminlist();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HRLog hlogPage = new HRLog();
            hlogPage.Visible = true;
        }

        public void adminlist()
        {
            try
            {
                DBconnection();
                SqlCommand usertable = new SqlCommand("SELECT * FROM ADMINTABLE", connection);
                DataTable dtbl = new DataTable();
                SqlDataReader read = usertable.ExecuteReader();

                dtbl.Load(read);

                dataGridView1.DataSource = dtbl;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retriving");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profile_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        // Password Validity
        public bool IsPasswordStrong(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false, hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if ("!@#$%^&*".Contains(c)) hasSpecial = true;

                if (hasUpper && hasLower && hasDigit && hasSpecial)
                    return true;
            }
            return false;
        }

        // Email Validity
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return true;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string name = hrnamebox.Text.ToString();
            string mail = hrmailbox.Text.ToString().Trim();
            string newpass = hrnewpassbox.Text.ToString();
            string confirmpass = hrconfirmpassbox.Text.ToString();
            string currpass = hrcurrentpassbox.Text.ToString();
            string gender = hrgenderbox.Text.ToString();
            string country = hrcountrybox.Text.ToString();
            string city = hrcitybox.Text.ToString();

            if (string.Equals(currpass, hrpass))
            {

                if (IsValidEmail(mail))
                {
                    if (string.IsNullOrEmpty(newpass) && string.IsNullOrEmpty(confirmpass))
                    {
                        try
                        {
                            DBconnection();
                            SqlCommand saveUser = new SqlCommand("update hrtable set hr_name = @name , hr_mail = @mail, hr_gender = @gender, hr_adress_country = @country, hr_adress_city = @city, hr_pass = @hrpass WHERE HID_number = @userId", connection);
                            saveUser.Parameters.AddWithValue("@name", name);
                            saveUser.Parameters.AddWithValue("@mail", mail);
                            saveUser.Parameters.AddWithValue("@gender", gender);
                            saveUser.Parameters.AddWithValue("@country", country);
                            saveUser.Parameters.AddWithValue("@city", city);
                            saveUser.Parameters.AddWithValue("@userId", hid);
                            saveUser.Parameters.AddWithValue("@hrpass", hrpass);
                            saveUser.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("UPDATED");

                            hrnewpassbox.Text = "";
                            hrconfirmpassbox.Text = "";
                            hrcurrentpassbox.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error In Saving Data");
                        }
                    }
                    else
                    {
                        if (string.Equals(newpass, confirmpass))
                        {
                            if (IsPasswordStrong(newpass))
                            {
                                try
                                {
                                    DBconnection();
                                    SqlCommand saveUser = new SqlCommand("update hrtable set hr_name = @name , hr_mail = @mail, hr_gender = @gender, hr_pass = @pass, hr_adress_country = @country, hr_adress_city = @city WHERE HID_number = @userId", connection);
                                    saveUser.Parameters.AddWithValue("@name", name);
                                    saveUser.Parameters.AddWithValue("@mail", mail);
                                    saveUser.Parameters.AddWithValue("@gender", gender);
                                    saveUser.Parameters.AddWithValue("@pass", newpass);
                                    saveUser.Parameters.AddWithValue("@country", country);
                                    saveUser.Parameters.AddWithValue("@city", city);
                                    saveUser.Parameters.AddWithValue("@userId", hid);
                                    saveUser.ExecuteNonQuery();
                                    connection.Close();

                                    MessageBox.Show("UPDATED");


                                    hnamebox.Text = "";
                                    hmailbox.Text = "";
                                    hpassbox.Text = "";
                                    hcountrybox.Text = "";
                                    hcitybox.Text = "";
                                    hphnbox.Text = "";
                                    hgenderbox.Text = "";
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error In Saving Data");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Current password not strong");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Current password doesn't match");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Mail");
                }
            }
            else
            {
                MessageBox.Show("Invalid Pass");
            }

            hrinfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = hnamebox.Text.ToString();
            string mail = hmailbox.Text.ToString().Trim();
            string pass = hpassbox.Text.ToString();
            string country = hcountrybox.Text.ToString();
            string city = hcitybox.Text.ToString();
            string phn = hphnbox.Text.ToString();
            string gender = hgenderbox.Text.ToString();

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(mail) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(country) || String.IsNullOrEmpty(city) || String.IsNullOrEmpty(phn))
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                try
                {
                    DBconnection();
                    SqlCommand saveUser = new SqlCommand("INSERT INTO HRTABLE(HR_NAME, HR_MAIL, HR_GENDER, HR_ADRESS_COUNTRY, HR_ADRESS_CITY, HR_PASS, HR_PHN)" +
                                                            "VALUES (@name, @mail, @gender, @country, @city, @pass, @phn)", connection);
                    saveUser.Parameters.AddWithValue("@name", name);
                    saveUser.Parameters.AddWithValue("@mail", mail);
                    saveUser.Parameters.AddWithValue("@gender", gender);
                    saveUser.Parameters.AddWithValue("@pass", pass);
                    saveUser.Parameters.AddWithValue("@country", country);
                    saveUser.Parameters.AddWithValue("@city", city);
                    saveUser.Parameters.AddWithValue("@phn", phn);
                    saveUser.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("UPDATED");

                    // Clearing the fields after saving
                    hnamebox.Text = "";
                    hmailbox.Text = "";
                    hpassbox.Text = "";
                    hcountrybox.Text = "";
                    hcitybox.Text = "";
                    hphnbox.Text = "";
                    hgenderbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = adminnamebox.Text.ToString();
            string mail = adminmailbox.Text.ToString().Trim();
            string pass = adminpassbox.Text.ToString();
            string country = admincountrybox.Text.ToString();
            string city = admincitybox.Text.ToString();
            string phn = adminphnbox.Text.ToString();
            string gender = admingenderbox.Text.ToString();


            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(mail) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(country) || String.IsNullOrEmpty(city) || String.IsNullOrEmpty(phn))
            {
                MessageBox.Show("Please Fill All The Fields");
            }
            else
            {
                try
                {
                    DBconnection();
                    SqlCommand saveUser = new SqlCommand("INSERT INTO ADMINTABLE(ADMIN_NAME, ADMIN_MAIL, ADMIN_GENDER, ADMIN_ADRESS_COUNTRY, ADMIN_ADRESS_CITY, ADMIN_PASS, ADMIN_PHN) " +
                                                            "VALUES (@name, @mail, @gender, @country, @city, @pass, @phn)", connection);
                    saveUser.Parameters.AddWithValue("@name", name);
                    saveUser.Parameters.AddWithValue("@mail", mail);
                    saveUser.Parameters.AddWithValue("@gender", gender);
                    saveUser.Parameters.AddWithValue("@pass", pass);
                    saveUser.Parameters.AddWithValue("@country", country);
                    saveUser.Parameters.AddWithValue("@city", city);
                    saveUser.Parameters.AddWithValue("@phn", phn);
                    saveUser.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("UPDATED");

                    // Clearing the fields after saving
                    adminnamebox.Text= "";
                    adminmailbox.Text = "";
                    adminpassbox.Text = "";
                    admincountrybox.Text = "";
                    admincitybox.Text = "";
                    adminphnbox.Text = "";
                    admingenderbox.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error In Saving Data");
                }
            }
        }
    }
}
