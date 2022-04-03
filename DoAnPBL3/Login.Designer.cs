
namespace DoAnPBL3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.radioEmployee = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.blueEyeIcon = new System.Windows.Forms.PictureBox();
            this.blueEyeSlashIcon = new System.Windows.Forms.PictureBox();
            this.exitIcon = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blueEyeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueEyeSlashIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(98, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(98, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(104, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đăng Nhập";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(102, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(102, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 1);
            this.panel2.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtUserName.Location = new System.Drawing.Point(102, 259);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 19);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPassword.Location = new System.Drawing.Point(102, 375);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 19);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPassword.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(199, 483);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(129, 20);
            this.linkLabelForgotPassword.TabIndex = 4;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Quên Mật Khẩu?";
            this.linkLabelForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgotPassword_LinkClicked);
            // 
            // radioEmployee
            // 
            this.radioEmployee.AutoSize = true;
            this.radioEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEmployee.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioEmployee.Location = new System.Drawing.Point(227, 436);
            this.radioEmployee.Name = "radioEmployee";
            this.radioEmployee.Size = new System.Drawing.Size(101, 24);
            this.radioEmployee.TabIndex = 3;
            this.radioEmployee.Text = "Nhân Viên";
            this.radioEmployee.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Checked = true;
            this.radioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioAdmin.Location = new System.Drawing.Point(54, 436);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(87, 24);
            this.radioAdmin.TabIndex = 3;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Quản Trị";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // blueEyeIcon
            // 
            this.blueEyeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueEyeIcon.Image = global::DoAnPBL3.Properties.Resources.blue_eye_icon;
            this.blueEyeIcon.Location = new System.Drawing.Point(318, 358);
            this.blueEyeIcon.Name = "blueEyeIcon";
            this.blueEyeIcon.Size = new System.Drawing.Size(44, 40);
            this.blueEyeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueEyeIcon.TabIndex = 12;
            this.blueEyeIcon.TabStop = false;
            this.blueEyeIcon.Click += new System.EventHandler(this.blueEyeIcon_Click);
            // 
            // blueEyeSlashIcon
            // 
            this.blueEyeSlashIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueEyeSlashIcon.Image = global::DoAnPBL3.Properties.Resources.blue_eye_slash_icon;
            this.blueEyeSlashIcon.Location = new System.Drawing.Point(318, 358);
            this.blueEyeSlashIcon.Name = "blueEyeSlashIcon";
            this.blueEyeSlashIcon.Size = new System.Drawing.Size(44, 40);
            this.blueEyeSlashIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueEyeSlashIcon.TabIndex = 11;
            this.blueEyeSlashIcon.TabStop = false;
            this.blueEyeSlashIcon.Click += new System.EventHandler(this.blueEyeSlashIcon_Click);
            // 
            // exitIcon
            // 
            this.exitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitIcon.Image = global::DoAnPBL3.Properties.Resources.navy_exit_icon;
            this.exitIcon.Location = new System.Drawing.Point(364, 0);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(47, 48);
            this.exitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitIcon.TabIndex = 10;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(137, 530);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DoAnPBL3.Properties.Resources.user_icon;
            this.pictureBox3.Location = new System.Drawing.Point(22, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.private_xxl;
            this.pictureBox2.Location = new System.Drawing.Point(16, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.bookstore_icon;
            this.pictureBox1.Location = new System.Drawing.Point(155, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 611);
            this.Controls.Add(this.blueEyeIcon);
            this.Controls.Add(this.blueEyeSlashIcon);
            this.Controls.Add(this.radioEmployee);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.exitIcon);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blueEyeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueEyeSlashIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.PictureBox exitIcon;
        private System.Windows.Forms.RadioButton radioEmployee;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.PictureBox blueEyeSlashIcon;
        private System.Windows.Forms.PictureBox blueEyeIcon;
    }
}