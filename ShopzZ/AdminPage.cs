using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AmaZon
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            Profile_panel.Visible = true;
            ProdutADD_panel.Visible = false;
            bandUser_panel.Visible = false;
            panel1.Visible = false;
            Order_panel.Visible = false;

            productlist();
            admindata();
            orderlistshow();
        }

        public int adminid = 0;

        SqlConnection connection;
        public void DBconnection()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\CODE Files\\VS 2022\\ShopzZ\\DB\\DemoDB.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            connection.Open();
        }
        private void admin_info_button_Click(object sender, EventArgs e)
        {
            Profile_panel.Visible = true;
            ProdutADD_panel.Visible = false;
            bandUser_panel.Visible = false;
            panel1.Visible = false;
            Order_panel.Visible = false;
            admindata();
        }

        public string adminpass;

        public void admindata()
        {
            try
            {
                DBconnection();
                SqlCommand profileinformation = new SqlCommand("select * from admintable where AID_number = @num", connection);
                profileinformation.Parameters.AddWithValue("@num", adminid);
                SqlDataReader reader = profileinformation.ExecuteReader();
                while (reader.Read())
                {
                    adminidbox.Text = Convert.ToString(reader.GetValue(1));
                    adminphnbox.Text = Convert.ToString(reader.GetValue(8));
                    namebox.Text = Convert.ToString(reader.GetValue(2));
                    mailbox.Text = Convert.ToString(reader.GetValue(3));
                    genderbox.Text = Convert.ToString(reader.GetValue(4));
                    adressbox.Text = Convert.ToString(reader.GetValue(6) + " " + reader.GetValue(5));
                    countrybox.Text = Convert.ToString(reader.GetValue(5));
                    citybox.Text = Convert.ToString(reader.GetValue(6));
                    adminpass = Convert.ToString(reader.GetValue(7));
                    
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error in Profile");
            }
        }

        private void band_user_button_Click(object sender, EventArgs e)
        {
            Profile_panel.Visible = false;
            ProdutADD_panel.Visible = false;
            bandUser_panel.Visible = true;
            panel1.Visible = false;
            Order_panel.Visible = false;

            try
            {
                DBconnection();
                SqlCommand usertable = new SqlCommand("SELECT * FROM USERTABLE", connection);
                DataTable dtbl = new DataTable();
                SqlDataReader read = usertable.ExecuteReader();

                dtbl.Load(read);

                userDBview.DataSource = dtbl;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retriving");
            }
        }

        private void add_product_button_Click(object sender, EventArgs e)
        {
            Profile_panel.Visible = false;
            ProdutADD_panel.Visible = true;
            bandUser_panel.Visible = false;
            panel1.Visible = false;
            Order_panel.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile_panel.Visible = false;
            ProdutADD_panel.Visible = false;
            bandUser_panel.Visible = false;
            panel1.Visible = true;
            Order_panel.Visible = false;
            productlist();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Order_panel.Visible = true;
            Profile_panel.Visible = false;
            ProdutADD_panel.Visible = false;
            bandUser_panel.Visible = false;
            panel1.Visible = false;
            OrderShow_FlowPnael.Controls.Clear();

           // for order list show DB
            orderlistshow();
        }
        
        //
        public void listofOrder(string order)
        {
            Panel displaypanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(372, 190),
                Size = new Size(581, 356)
            };

            System.Windows.Forms.Button back = new System.Windows.Forms.Button
            {
                Text = "Back",
                Location = new Point(10, 20),
                Size = new Size(60, 40),
                Font = new Font("Palatino Linotype", 12)
            };
            back.Click += (s, args) =>
            {
                displaypanel.Dispose();
            };

            displaypanel.Controls.Add(back);
            FlowLayoutPanel list = new FlowLayoutPanel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(20, 80),
                Size = new Size(542, 260),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown
            };

            Label orders = new Label
            {
                Text = order,
                Location = new Point(146, 13),
                AutoSize = true,
                Font = new Font("Palatino Linotype", 12)
            };

            list.Controls.Add(orders);
            displaypanel.Controls.Add(list);

            this.Controls.Add(displaypanel);
            displaypanel.BringToFront();
        }
        private void OrderList_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bandUpdate_button_Click(object sender, EventArgs e)
        {
            try
            {
                DBconnection();
                SqlCommand update = new SqlCommand("UPDATE USERTABLE SET BANNED_USER = @ban WHERE UID_NUMBER = @idnum", connection);
                update.Parameters.AddWithValue("@idnum", banuseridbox.Text.ToString().Trim());
                update.Parameters.AddWithValue("@ban", banornotbox.Text.ToString());
                update.ExecuteNonQuery();
                connection.Close();

                banuseridbox.Text = "";
                banornotbox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No information");
            }

            // Refresh of Table
            try
            {
                DBconnection();
                SqlCommand usertable = new SqlCommand("SELECT * FROM USERTABLE", connection);
                DataTable dtbl = new DataTable();
                SqlDataReader read = usertable.ExecuteReader();

                dtbl.Load(read);

                userDBview.DataSource = dtbl;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retriving");
            }


        }

        public string imagepath = " ";
        private void browsbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)

            {
                imagepath = dialog.FileName;
                productpicbox.Image = System.Drawing.Image.FromFile(imagepath);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pID = productidbox.Text.ToString();
            string pName = productnamebox.Text.ToString();
            string pPrice = productpricebox.Text.ToString();
            string pQunatity = productquantirybox.Text.ToString();
            string pCatagory = productcatagorybox.Text.ToString();
            string pDes1 = descrip1box.Text.ToString();
            string pDes2 = descrip2box.Text.ToString();

            bool inDB = false;
            try
            {
                DBconnection();
                SqlCommand dbcheck = new SqlCommand("SELECT * FROM PRODUCTTABLE WHERE PRODUCT_ID = @id", connection);
                dbcheck.Parameters.AddWithValue("@id", pID);
                DataTable dtbl = new DataTable();
                SqlDataReader read = dbcheck.ExecuteReader();
                dtbl.Load(read);

                if (dtbl.Rows.Count == 1)
                    inDB = true;
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Error in searching in Product Table");
            }

            if (string.IsNullOrEmpty(pID) && string.IsNullOrEmpty(pName) && string.IsNullOrEmpty(pPrice)
                && string.IsNullOrEmpty(pQunatity) && string.IsNullOrEmpty(pCatagory) && string.IsNullOrEmpty(pDes1)
                && string.IsNullOrEmpty(pDes2) && string.IsNullOrEmpty(imagepath))
            {
                MessageBox.Show("Product Info missing");
            }
            else if (inDB)
            {
                try
                {
                    DBconnection();
                    SqlCommand productsave = new SqlCommand("UPDATE PRODUCTTABLE SET PRODUCT_NAME = @name, PRODUCT_DESCRIPTION1 = @des1, PRODUCT_DESCRIPTION2 = @des2, PRODUCT_PRICE = @price," +
                                                            " PRODUCT_STOCK = @stock, PRODUCT_CATAGORY = @catagory, PRODUCT_IMAGE = @image WHERE PRODUCT_ID = @id "
                                                            , connection);
                    productsave.Parameters.AddWithValue("@id", pID);
                    productsave.Parameters.AddWithValue("@name", pName);
                    productsave.Parameters.AddWithValue("@price", pPrice);
                    productsave.Parameters.AddWithValue("@stock", pQunatity);
                    productsave.Parameters.AddWithValue("@catagory", pCatagory);
                    productsave.Parameters.AddWithValue("@des1", pDes1);
                    productsave.Parameters.AddWithValue("@des2", pDes2);
                    productsave.Parameters.AddWithValue("@image", imagepath);
                    productsave.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("UPDATED");
                    productidbox.Text = "";
                    productnamebox.Text = "";
                    productpricebox.Text = "";
                    productquantirybox.Text = "";
                    productcatagorybox.Text = "";
                    descrip1box.Text = "";
                    descrip2box.Text = "";
                    imagepath = "";

                    productpicbox.Image = null;
                }
                catch
                {
                    MessageBox.Show("Error in Updating productable");
                }

            }
            else
            {
                try
                {
                    DBconnection();
                    SqlCommand productsave = new SqlCommand("INSERT INTO PRODUCTTABLE(PRODUCT_ID, PRODUCT_NAME, PRODUCT_DESCRIPTION1, PRODUCT_DESCRIPTION2, PRODUCT_PRICE, PRODUCT_STOCK, PRODUCT_CATAGORY, PRODUCT_IMAGE)" +
                                                            "VALUES(@id,@name, @des1, @des2, @price, @stock, @catagory, @image)", connection);
                    productsave.Parameters.AddWithValue("@id", pID);
                    productsave.Parameters.AddWithValue("@name", pName);
                    productsave.Parameters.AddWithValue("@price", pPrice);
                    productsave.Parameters.AddWithValue("@stock", pQunatity);
                    productsave.Parameters.AddWithValue("@catagory", pCatagory);
                    productsave.Parameters.AddWithValue("@des1", pDes1);
                    productsave.Parameters.AddWithValue("@des2", pDes2);
                    productsave.Parameters.AddWithValue("@image", imagepath);
                    productsave.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Saved");
                    productidbox.Text = "";
                    productnamebox.Text = "";
                    productpricebox.Text = "";
                    productquantirybox.Text = "";
                    productcatagorybox.Text = "";
                    descrip1box.Text = "";
                    descrip2box.Text = "";
                    imagepath = "";

                    productpicbox.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem In values");
                }
            }
        }

        

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
            string name = namebox.Text.ToString();
            string mail = mailbox.Text.ToString().Trim();
            string newpass = newpassbox.Text.ToString();
            string confirmpass = confirmpassbox.Text.ToString();
            string currpass = currentpassbox.Text.ToString().Trim();
            string gender = genderbox.Text.ToString();
            string country = countrybox.Text.ToString();
            string city = citybox.Text.ToString();
            string phn = adminphnbox.Text.ToString();

            if (string.Equals(currpass, adminpass))
            {

                if (IsValidEmail(mail))
                {
                    if (string.IsNullOrEmpty(newpass) && string.IsNullOrEmpty(confirmpass))
                    {
                        try
                        {
                            DBconnection();
                            SqlCommand saveUser = new SqlCommand("update admintable set admin_name = @name , admin_mail = @mail, admin_gender = @gender, admin_adress_country = @country, admin_adress_city = @city, admin_phn = @phn WHERE AID_number = @userId", connection);
                            saveUser.Parameters.AddWithValue("@name", name);
                            saveUser.Parameters.AddWithValue("@mail", mail);
                            saveUser.Parameters.AddWithValue("@gender", gender);
                            saveUser.Parameters.AddWithValue("@country", country);
                            saveUser.Parameters.AddWithValue("@city", city);
                            saveUser.Parameters.AddWithValue("@userId", adminid);
                            saveUser.Parameters.AddWithValue("@phn", phn);
                            saveUser.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("UPDATED");

                            adressbox.Text = city + ", " + country;
                            newpassbox.Text = "";
                            confirmpassbox.Text = "";
                            currentpassbox.Text = "";
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
                                    SqlCommand saveUser = new SqlCommand("update admintable set admin_name = @name , admin_mail = @mail, admin_gender = @gender, admin_pass = @pass, admin_adress_country = @country, admin_adress_city = @city, admin_phn = @phn WHERE AID_number = @userId", connection);
                                    saveUser.Parameters.AddWithValue("@name", name);
                                    saveUser.Parameters.AddWithValue("@mail", mail);
                                    saveUser.Parameters.AddWithValue("@gender", gender);
                                    saveUser.Parameters.AddWithValue("@pass", newpass);
                                    saveUser.Parameters.AddWithValue("@country", country);
                                    saveUser.Parameters.AddWithValue("@city", city);
                                    saveUser.Parameters.AddWithValue("@userId", adminid);
                                    saveUser.Parameters.AddWithValue("@phn", phn);
                                    saveUser.ExecuteNonQuery();
                                    connection.Close();

                                    MessageBox.Show("UPDATED");


                                    newpassbox.Text = "";
                                    confirmpassbox.Text = "";
                                    currentpassbox.Text = "";
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
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            admindata();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLog log = new AdminLog();
            log.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void productlist()
        {
            try
            {
                DBconnection();
                SqlCommand usertable = new SqlCommand("SELECT * FROM PRODUCTTABLE", connection);
                DataTable dtbl = new DataTable();
                SqlDataReader read = usertable.ExecuteReader();

                dtbl.Load(read);

                ProductView.DataSource = dtbl;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retriving");
            }
        }
        public void orderlistshow()
        {
            DBconnection();
            SqlCommand profileinformation = new SqlCommand("SELECT * FROM ORDERTABLE", connection);

            SqlDataReader reader = profileinformation.ExecuteReader();

            while (reader.Read())
            {
                string OrderNumber = Convert.ToString(reader.GetValue(0));
                string User = Convert.ToString(reader.GetValue(5));
                string orders = Convert.ToString(reader.GetValue(1));

                order(OrderNumber, User, orders);
            }

            connection.Close();
        }
        public void order(string OrderNumber, string Userid, string Orders)
        {
            Panel orderpanel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(662, 121),
                Margin = new Padding(10)

            };

            Label orderlabel = new Label
            {
                Text = "Order number",
                Location = new Point(29, 13),
                AutoSize = true,
                Font = new Font("Palatino Linotype", 12)
            };
            orderpanel.Controls.Add(orderlabel);

            Label ordernum = new Label
            {
                Text = OrderNumber,
                Location = new Point(146, 13),
                AutoSize = true,
                Font = new Font("Palatino Linotype", 12)
            };
            orderpanel.Controls.Add(ordernum);


            Label userlabel = new Label
            {
                Text = "User ID",
                Location = new Point(236, 13),
                AutoSize = true,
                Font = new Font("Palatino Linotype", 12)
            };
            orderpanel.Controls.Add(userlabel);

            Label userID = new Label
            {
                Text = Userid,
                Location = new Point(320, 13),
                AutoSize = true,
                Font = new Font("Palatino Linotype", 12)
            };
            orderpanel.Controls.Add(userID);

            FlowLayoutPanel orderlist = new FlowLayoutPanel
            {
                BorderStyle = BorderStyle.Fixed3D,
                Location = new Point(32, 43),
                Size = new Size(605, 62),
                FlowDirection = FlowDirection.LeftToRight,
                AutoScroll = true,
                Visible = true
            };

            // Button to show order list
            orderlist.Click += (s, args) =>
            {
                listofOrder(Orders);
            };

            Label orders = new Label
            {
                Text = Orders,
                AutoSize = true,
                Font = new Font("Palatino Linotype", 12)
            };
            orderlist.Controls.Add(orders);
            orderpanel.Controls.Add(orderlist);

            // panel to add
            OrderShow_FlowPnael.Controls.Add(orderpanel);
        }

        private void AdminPage_Load_1(object sender, EventArgs e)
        {
            //admin data after login show 1st panel
            admindata();
        }
    }
}
