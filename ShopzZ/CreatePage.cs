using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Forms;

namespace AmaZon
{
    public partial class CreatePage : Form
    {
        public CreatePage()
        {
            InitializeComponent();
            createerrortag.Visible = false;
        }

        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }

        // Full Name Box Animation
        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Full Name")
            {
                name.Text = "";
                name.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {   
            if(name.Text == "")
            {
                name.Text = "Name";
                name.ForeColor = System.Drawing.Color.LightGray;
            }
           
        }

        //Email Animation
        private void email_Enter(object sender, EventArgs e)
        {
            if(email.Text == "Email")
            {
                email.Text = "";
                email.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
                email.ForeColor = System.Drawing.Color.LightGray;
            }
        }
        // Gender Box Animation
        private void gender_Enter(object sender, EventArgs e)
        {
            if (gender.Text == "Gender")
                gender.Text = "";
                gender.ForeColor = System.Drawing.Color.Black;
        }

        private void gender_Leave(object sender, EventArgs e)
        {
            if (gender.Text == "")
            {
                gender.Text = "Gender";
                gender.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        //Password Box animation
        private void createpassword_Enter(object sender, EventArgs e)
        {
            if(createpassword.Text == "Password")
            {
                createpassword.Text = "";
                createpassword.ForeColor = System.Drawing.Color.Black;
                createpassword.UseSystemPasswordChar = true;
            }
        }

        private void createpassword_Leave(object sender, EventArgs e)
        {
            if (createpassword.Text == "")
            {
                createpassword.Text = "Password";
                createpassword.ForeColor = System.Drawing.Color.LightGray;
                createpassword.UseSystemPasswordChar = false;
            }
        }

        // Retype Password Box Animation
        private void retypepassword_Enter(object sender, EventArgs e)
        {
            if(retypepassword.Text == "Re-type Password")
            {
                retypepassword.Text = "";
                retypepassword.ForeColor = System.Drawing.Color.Black;
                retypepassword.UseSystemPasswordChar = true;
            }
        }

        private void retypepassword_Leave(object sender, EventArgs e)
        {
            if (retypepassword.Text == "")
            {
                retypepassword.Text = "Re-type Password";
                retypepassword.ForeColor = System.Drawing.Color.LightGray;
                retypepassword.UseSystemPasswordChar = false;
            }
        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(Showpass.Checked == true)
            {
                retypepassword.UseSystemPasswordChar = false;
                createpassword.UseSystemPasswordChar= false;
            }
            else
            {
                retypepassword.UseSystemPasswordChar = true;
                createpassword.UseSystemPasswordChar = true;
            }
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

            string pattern = "^[a-zA-Z0-9._%+-]+@(gmail|yahoo|email|hotmail)+.com$";
            return Regex.IsMatch(email, pattern);
        }

        public bool InDB(string email)
        {
            try
            {
                DBconnection();
                SqlCommand mailindnb = new SqlCommand("SELECT * FROM USERTABLE WHERE USER_MAIL = @usermail", connection);
                mailindnb.Parameters.AddWithValue("@usermail", email);
                DataTable dtb = new DataTable();
                SqlDataReader mailread = mailindnb.ExecuteReader();

                dtb.Load(mailread);

                if (dtb.Rows.Count == 1)
                {
                    return true;
                }

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error in retriving email existance");

            }

            return false;
        }
        private void createaccount_Click(object sender, EventArgs e)
        {
            string mail  = email.Text.ToString();
            string Password = createpassword.Text.ToString();
            string retype = retypepassword.Text.ToString();
            string ban = "No";

            if (InDB(mail))
            {
                if (mail != "Email" && mail != string.Empty && IsValidEmail(mail))
                {
                    if (Password != "Password" && Password != string.Empty && IsPasswordStrong(Password))
                    {
                        if (Password == retype)
                        {
                            {
                                try
                                {
                                    DBconnection();
                                    SqlCommand saveUser = new SqlCommand("insert into Usertable(user_name,user_mail,user_gender,user_pass,banned_user) values(@name,@mail,@gender,@pass,@ban)", connection);
                                    saveUser.Parameters.AddWithValue("@name", name.Text);
                                    saveUser.Parameters.AddWithValue("@mail", email.Text);
                                    saveUser.Parameters.AddWithValue("@gender", gender.Text);
                                    saveUser.Parameters.AddWithValue("@pass", createpassword.Text);
                                    saveUser.Parameters.AddWithValue("@ban", ban);
                                    saveUser.ExecuteNonQuery();

                                    SqlCommand saveid = new SqlCommand("select UID_number from usertable where user_mail = @email and user_pass = @password", connection);
                                    saveid.Parameters.AddWithValue("@email", email.Text);
                                    saveid.Parameters.AddWithValue("@password", createpassword.Text);
                                    int idnum = Convert.ToInt32(saveid.ExecuteScalar());
                                    connection.Close();
                                    this.Hide();
                                    HomePage page = new HomePage();
                                    page.Visible = true;
                                    page.userid = idnum;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Creating Error");
                                }
                            }
                        }
                        else
                        {
                            createerrortag.Visible = true;
                            createerrortag.Text = "Password Mismatch";
                        }
                    }
                    else
                    {
                        createerrortag.Visible = true;
                        createerrortag.Text = "Password not Strong enough";
                    }
                }
                else
                {
                    createerrortag.Visible = true;
                    createerrortag.Text = "Mail not available";
                }
            }
            else
            {
                createerrortag.Visible = true;
                createerrortag.Text = "Mail already in use";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogPage l = new LogPage();
            l.Show();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
