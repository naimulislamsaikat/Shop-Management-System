namespace AmaZon
{
    partial class CreatePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePage));
            this.title = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.createaccount = new System.Windows.Forms.Button();
            this.Showpass = new System.Windows.Forms.CheckBox();
            this.email = new System.Windows.Forms.TextBox();
            this.createpassword = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.retypepassword = new System.Windows.Forms.TextBox();
            this.createerrortag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Centaur", 57.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(84, 83);
            this.title.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(470, 86);
            this.title.TabIndex = 0;
            this.title.Text = "Create Account";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.LightGray;
            this.name.Location = new System.Drawing.Point(94, 229);
            this.name.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(433, 31);
            this.name.TabIndex = 1;
            this.name.Text = "Full Name";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // createaccount
            // 
            this.createaccount.Location = new System.Drawing.Point(94, 604);
            this.createaccount.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.createaccount.Name = "createaccount";
            this.createaccount.Size = new System.Drawing.Size(437, 50);
            this.createaccount.TabIndex = 0;
            this.createaccount.Text = "Create new account";
            this.createaccount.UseVisualStyleBackColor = true;
            this.createaccount.Click += new System.EventHandler(this.createaccount_Click);
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.Location = new System.Drawing.Point(94, 560);
            this.Showpass.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Showpass.Name = "Showpass";
            this.Showpass.Size = new System.Drawing.Size(181, 32);
            this.Showpass.TabIndex = 6;
            this.Showpass.Text = "Show Password";
            this.Showpass.UseVisualStyleBackColor = true;
            this.Showpass.CheckedChanged += new System.EventHandler(this.Showpass_CheckedChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.LightGray;
            this.email.Location = new System.Drawing.Point(94, 295);
            this.email.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(433, 31);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // createpassword
            // 
            this.createpassword.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createpassword.ForeColor = System.Drawing.Color.LightGray;
            this.createpassword.Location = new System.Drawing.Point(94, 420);
            this.createpassword.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.createpassword.Name = "createpassword";
            this.createpassword.Size = new System.Drawing.Size(433, 31);
            this.createpassword.TabIndex = 4;
            this.createpassword.Text = "Password";
            this.createpassword.Enter += new System.EventHandler(this.createpassword_Enter);
            this.createpassword.Leave += new System.EventHandler(this.createpassword_Leave);
            // 
            // gender
            // 
            this.gender.ForeColor = System.Drawing.Color.LightGray;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(94, 357);
            this.gender.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(433, 36);
            this.gender.TabIndex = 3;
            this.gender.Text = "Gender";
            this.gender.Enter += new System.EventHandler(this.gender_Enter);
            this.gender.Leave += new System.EventHandler(this.gender_Leave);
            // 
            // retypepassword
            // 
            this.retypepassword.Font = new System.Drawing.Font("Centaur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypepassword.ForeColor = System.Drawing.Color.LightGray;
            this.retypepassword.Location = new System.Drawing.Point(94, 484);
            this.retypepassword.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.retypepassword.Name = "retypepassword";
            this.retypepassword.Size = new System.Drawing.Size(433, 31);
            this.retypepassword.TabIndex = 5;
            this.retypepassword.Text = "Re-type Password";
            this.retypepassword.Enter += new System.EventHandler(this.retypepassword_Enter);
            this.retypepassword.Leave += new System.EventHandler(this.retypepassword_Leave);
            // 
            // createerrortag
            // 
            this.createerrortag.AutoSize = true;
            this.createerrortag.ForeColor = System.Drawing.Color.IndianRed;
            this.createerrortag.Location = new System.Drawing.Point(89, 526);
            this.createerrortag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createerrortag.Name = "createerrortag";
            this.createerrortag.Size = new System.Drawing.Size(69, 28);
            this.createerrortag.TabIndex = 25;
            this.createerrortag.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(302, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Click Here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.createerrortag);
            this.panel1.Controls.Add(this.Showpass);
            this.panel1.Controls.Add(this.retypepassword);
            this.panel1.Controls.Add(this.createaccount);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.createpassword);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 730);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkViolet;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(609, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 732);
            this.panel2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(91, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 64);
            this.label2.TabIndex = 27;
            this.label2.Text = "Welcome to ShopzZ\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(158, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 56);
            this.label3.TabIndex = 28;
            this.label3.Text = "If you already have an account,\r\n             Please";
            // 
            // CreatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 729);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "CreatePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AmaZon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button createaccount;
        private System.Windows.Forms.CheckBox Showpass;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox createpassword;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.TextBox retypepassword;
        private System.Windows.Forms.Label createerrortag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}