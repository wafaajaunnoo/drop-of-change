
namespace dropofchange
{
    partial class records
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
            this.appTitle = new System.Windows.Forms.Label();
            this.navigation_menu = new System.Windows.Forms.Panel();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.navigation_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.appTitle);
            this.panel1.Location = new System.Drawing.Point(-5, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1693, 74);
            this.panel1.TabIndex = 2;
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(600, 14);
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
            // records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 812);
            this.Controls.Add(this.navigation_menu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1707, 886);
            this.Name = "records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECORDS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.navigation_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Panel navigation_menu;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnExit;
    }
}