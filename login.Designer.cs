
namespace dropofchange
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.application_name = new System.Windows.Forms.Panel();
            this.appTitle = new System.Windows.Forms.Label();
            this.navigation_menu = new System.Windows.Forms.Panel();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.btnLoginAdmin = new dropofchange.CircularButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.application_name.SuspendLayout();
            this.navigation_menu.SuspendLayout();
            this.groupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // application_name
            // 
            this.application_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.application_name.Controls.Add(this.appTitle);
            this.application_name.Location = new System.Drawing.Point(-1, 78);
            this.application_name.Margin = new System.Windows.Forms.Padding(4);
            this.application_name.Name = "application_name";
            this.application_name.Size = new System.Drawing.Size(1545, 70);
            this.application_name.TabIndex = 1;
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(564, 14);
            this.appTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(423, 48);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "DROP OF CHANGE";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // navigation_menu
            // 
            this.navigation_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.navigation_menu.Controls.Add(this.btnExit);
            this.navigation_menu.Controls.Add(this.btnAdmission);
            this.navigation_menu.Controls.Add(this.btnLogin);
            this.navigation_menu.Controls.Add(this.btnRecords);
            this.navigation_menu.Location = new System.Drawing.Point(-1, 144);
            this.navigation_menu.Margin = new System.Windows.Forms.Padding(4);
            this.navigation_menu.Name = "navigation_menu";
            this.navigation_menu.Size = new System.Drawing.Size(1525, 116);
            this.navigation_menu.TabIndex = 8;
            // 
            // btnAdmission
            // 
            this.btnAdmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.btnAdmission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmission.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.btnAdmission.FlatAppearance.BorderSize = 0;
            this.btnAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmission.Image = global::dropofchange.Properties.Resources.student11;
            this.btnAdmission.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdmission.Location = new System.Drawing.Point(133, 11);
            this.btnAdmission.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(367, 101);
            this.btnAdmission.TabIndex = 2;
            this.btnAdmission.Text = "Student Admission";
            this.btnAdmission.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAdmission.UseVisualStyleBackColor = false;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.btnLogin.BackgroundImage = global::dropofchange.Properties.Resources.admin2;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogin.Location = new System.Drawing.Point(539, 11);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(273, 101);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Admin Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.btnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Image = global::dropofchange.Properties.Resources.records;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRecords.Location = new System.Drawing.Point(876, 11);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(251, 101);
            this.btnRecords.TabIndex = 4;
            this.btnRecords.Text = "Records";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // groupBox_login
            // 
            this.groupBox_login.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox_login.Controls.Add(this.btnLoginAdmin);
            this.groupBox_login.Controls.Add(this.panel1);
            this.groupBox_login.Controls.Add(this.txtPassword);
            this.groupBox_login.Controls.Add(this.pass);
            this.groupBox_login.Controls.Add(this.user);
            this.groupBox_login.Controls.Add(this.txtUsername);
            this.groupBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_login.Location = new System.Drawing.Point(408, 327);
            this.groupBox_login.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_login.Size = new System.Drawing.Size(664, 394);
            this.groupBox_login.TabIndex = 9;
            this.groupBox_login.TabStop = false;
            this.groupBox_login.Text = "Admin Login Form";
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginAdmin.FlatAppearance.BorderSize = 0;
            this.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnLoginAdmin.Location = new System.Drawing.Point(445, 224);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(100, 92);
            this.btnLoginAdmin.TabIndex = 10;
            this.btnLoginAdmin.Text = "LOGIN";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(26, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 223);
            this.panel1.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(397, 167);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(273, 174);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(97, 20);
            this.pass.TabIndex = 3;
            this.pass.Text = "Password:";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(270, 111);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 2;
            this.user.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(397, 104);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(209, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(551, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restricted: Only Admins are allowed to login!";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::dropofchange.Properties.Resources.logout;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.Location = new System.Drawing.Point(1175, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 101);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 812);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.navigation_menu);
            this.Controls.Add(this.application_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1707, 886);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN LOGIN";
            this.application_name.ResumeLayout(false);
            this.application_name.PerformLayout();
            this.navigation_menu.ResumeLayout(false);
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel application_name;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Panel navigation_menu;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.GroupBox groupBox_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private CircularButton btnLoginAdmin;
        private System.Windows.Forms.Button btnExit;
    }
}