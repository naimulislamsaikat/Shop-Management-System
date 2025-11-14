namespace AmaZon
{
    partial class AdminLog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShopzZtitle = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.errortag = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userback = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.ShopzZtitle);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.showpass);
            this.panel1.Controls.Add(this.errortag);
            this.panel1.Controls.Add(this.mail);
            this.panel1.Controls.Add(this.login);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 729);
            this.panel1.TabIndex = 0;
            // 
            // ShopzZtitle
            // 
            this.ShopzZtitle.AutoSize = true;
            this.ShopzZtitle.Font = new System.Drawing.Font("Centaur", 57.75F);
            this.ShopzZtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShopzZtitle.Location = new System.Drawing.Point(139, 162);
            this.ShopzZtitle.Name = "ShopzZtitle";
            this.ShopzZtitle.Size = new System.Drawing.Size(260, 86);
            this.ShopzZtitle.TabIndex = 25;
            this.ShopzZtitle.Text = "ShopzZ";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Font = new System.Drawing.Font("Centaur", 15.75F);
            this.password.ForeColor = System.Drawing.Color.LightGray;
            this.password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.password.Location = new System.Drawing.Point(133, 388);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.MaxLength = 30;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(266, 31);
            this.password.TabIndex = 28;
            this.password.Tag = "";
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Font = new System.Drawing.Font("Centaur", 15.75F);
            this.showpass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.showpass.Location = new System.Drawing.Point(132, 457);
            this.showpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(150, 28);
            this.showpass.TabIndex = 29;
            this.showpass.Text = "Show Password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // errortag
            // 
            this.errortag.AutoSize = true;
            this.errortag.Font = new System.Drawing.Font("Centaur", 15.75F);
            this.errortag.ForeColor = System.Drawing.Color.IndianRed;
            this.errortag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errortag.Location = new System.Drawing.Point(129, 431);
            this.errortag.Name = "errortag";
            this.errortag.Size = new System.Drawing.Size(56, 24);
            this.errortag.TabIndex = 30;
            this.errortag.Text = "label1";
            // 
            // mail
            // 
            this.mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mail.Font = new System.Drawing.Font("Centaur", 15.75F);
            this.mail.ForeColor = System.Drawing.Color.LightGray;
            this.mail.Location = new System.Drawing.Point(133, 334);
            this.mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(266, 31);
            this.mail.TabIndex = 27;
            this.mail.Text = "Email";
            this.mail.Enter += new System.EventHandler(this.mail_Enter);
            this.mail.Leave += new System.EventHandler(this.mail_Leave);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Centaur", 15.75F);
            this.login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.login.Location = new System.Drawing.Point(132, 494);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(266, 34);
            this.login.TabIndex = 26;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.userback);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(598, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 729);
            this.panel2.TabIndex = 1;
            // 
            // userback
            // 
            this.userback.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userback.Location = new System.Drawing.Point(207, 672);
            this.userback.Name = "userback";
            this.userback.Size = new System.Drawing.Size(196, 45);
            this.userback.TabIndex = 4;
            this.userback.Text = "I am a user";
            this.userback.UseVisualStyleBackColor = true;
            this.userback.Click += new System.EventHandler(this.userback_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(147, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 78);
            this.label2.TabIndex = 3;
            this.label2.Text = "This panel is only usable for the admin for \r\n            the purpose of handling" +
    " the \r\n                  administrative works.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(144, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Admin Panel";
            // 
            // AdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShopzZtitle;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Label errortag;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button userback;
    }
}