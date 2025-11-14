namespace AmaZon
{
    partial class LogPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogPage));
            this.adminbutton = new System.Windows.Forms.Button();
            this.tag = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toHr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createaccountbutton = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.TextBox();
            this.errortag = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.ShopzZtitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminbutton
            // 
            resources.ApplyResources(this.adminbutton, "adminbutton");
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.UseVisualStyleBackColor = true;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // tag
            // 
            resources.ApplyResources(this.tag, "tag");
            this.tag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tag.Name = "tag";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.toHr);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.adminbutton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.createaccountbutton);
            this.panel2.Controls.Add(this.tag);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // toHr
            // 
            resources.ApplyResources(this.toHr, "toHr");
            this.toHr.Name = "toHr";
            this.toHr.UseVisualStyleBackColor = true;
            this.toHr.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            // 
            // createaccountbutton
            // 
            resources.ApplyResources(this.createaccountbutton, "createaccountbutton");
            this.createaccountbutton.Name = "createaccountbutton";
            this.createaccountbutton.UseVisualStyleBackColor = true;
            this.createaccountbutton.Click += new System.EventHandler(this.createaccountbutton_Click);
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // mail
            // 
            resources.ApplyResources(this.mail, "mail");
            this.mail.ForeColor = System.Drawing.Color.LightGray;
            this.mail.Name = "mail";
            this.mail.TextChanged += new System.EventHandler(this.mail_TextChanged);
            this.mail.Enter += new System.EventHandler(this.mail_Enter);
            this.mail.Leave += new System.EventHandler(this.mail_Leave);
            // 
            // errortag
            // 
            resources.ApplyResources(this.errortag, "errortag");
            this.errortag.ForeColor = System.Drawing.Color.IndianRed;
            this.errortag.Name = "errortag";
            // 
            // showpass
            // 
            resources.ApplyResources(this.showpass, "showpass");
            this.showpass.Name = "showpass";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.ForeColor = System.Drawing.Color.LightGray;
            this.password.Name = "password";
            this.password.Tag = "";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // ShopzZtitle
            // 
            resources.ApplyResources(this.ShopzZtitle, "ShopzZtitle");
            this.ShopzZtitle.Name = "ShopzZtitle";
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
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // LogPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogPage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Label tag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button createaccountbutton;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label errortag;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label ShopzZtitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toHr;
    }
}

