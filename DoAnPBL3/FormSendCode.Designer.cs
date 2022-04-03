
namespace DoAnPBL3
{
    partial class FormSendCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSendCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.exitIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blueEyeSlashIcon = new System.Windows.Forms.PictureBox();
            this.blueEyeIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueEyeSlashIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueEyeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(70, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(96, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 476);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác Nhận Mã";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(100, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(100, 539);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 1);
            this.panel2.TabIndex = 5;
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerifyCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtVerifyCode.Location = new System.Drawing.Point(100, 514);
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.Size = new System.Drawing.Size(280, 19);
            this.txtVerifyCode.TabIndex = 3;
            this.txtVerifyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerifyCode_KeyPress);
            // 
            // btnSendCode
            // 
            this.btnSendCode.AutoSize = true;
            this.btnSendCode.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(291, 411);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(89, 30);
            this.btnSendCode.TabIndex = 2;
            this.btnSendCode.Text = "Gửi Mã";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_ClickAsync);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(291, 576);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 30);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(28, 576);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSendCode
            // 
            this.txtSendCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSendCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSendCode.Location = new System.Drawing.Point(100, 235);
            this.txtSendCode.Name = "txtSendCode";
            this.txtSendCode.Size = new System.Drawing.Size(280, 19);
            this.txtSendCode.TabIndex = 0;
            this.txtSendCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendCode_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(96, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật Khẩu Email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(100, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 1);
            this.panel3.TabIndex = 5;
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtEmailPassword.Location = new System.Drawing.Point(100, 357);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(280, 19);
            this.txtEmailPassword.TabIndex = 1;
            this.txtEmailPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailPassword_KeyPress);
            // 
            // exitIcon
            // 
            this.exitIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitIcon.Image = global::DoAnPBL3.Properties.Resources.navy_exit_icon;
            this.exitIcon.Location = new System.Drawing.Point(364, 0);
            this.exitIcon.Name = "exitIcon";
            this.exitIcon.Size = new System.Drawing.Size(47, 48);
            this.exitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitIcon.TabIndex = 11;
            this.exitIcon.TabStop = false;
            this.exitIcon.Click += new System.EventHandler(this.exitIcon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DoAnPBL3.Properties.Resources.bookstore_icon;
            this.pictureBox3.Location = new System.Drawing.Point(155, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DoAnPBL3.Properties.Resources.lock_xxl;
            this.pictureBox4.Location = new System.Drawing.Point(18, 306);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.verify_code_icon;
            this.pictureBox2.Location = new System.Drawing.Point(28, 476);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.Email_icon;
            this.pictureBox1.Location = new System.Drawing.Point(28, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // blueEyeSlashIcon
            // 
            this.blueEyeSlashIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueEyeSlashIcon.Image = global::DoAnPBL3.Properties.Resources.blue_eye_slash_icon;
            this.blueEyeSlashIcon.Location = new System.Drawing.Point(336, 340);
            this.blueEyeSlashIcon.Name = "blueEyeSlashIcon";
            this.blueEyeSlashIcon.Size = new System.Drawing.Size(44, 40);
            this.blueEyeSlashIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueEyeSlashIcon.TabIndex = 12;
            this.blueEyeSlashIcon.TabStop = false;
            this.blueEyeSlashIcon.Click += new System.EventHandler(this.blueEyeSlashIcon_Click);
            // 
            // blueEyeIcon
            // 
            this.blueEyeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueEyeIcon.Image = global::DoAnPBL3.Properties.Resources.blue_eye_icon;
            this.blueEyeIcon.Location = new System.Drawing.Point(336, 340);
            this.blueEyeIcon.Name = "blueEyeIcon";
            this.blueEyeIcon.Size = new System.Drawing.Size(44, 40);
            this.blueEyeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueEyeIcon.TabIndex = 13;
            this.blueEyeIcon.TabStop = false;
            this.blueEyeIcon.Click += new System.EventHandler(this.blueEyeIcon_Click);
            // 
            // FormSendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 639);
            this.Controls.Add(this.blueEyeIcon);
            this.Controls.Add(this.blueEyeSlashIcon);
            this.Controls.Add(this.exitIcon);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.txtEmailPassword);
            this.Controls.Add(this.txtSendCode);
            this.Controls.Add(this.txtVerifyCode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSendCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác Nhận Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.exitIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueEyeSlashIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueEyeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtVerifyCode;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSendCode;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox exitIcon;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.PictureBox blueEyeSlashIcon;
        private System.Windows.Forms.PictureBox blueEyeIcon;
    }
}