
namespace DoAnPBL3
{
    partial class FormAddKH
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rjtbNameNV = new DoAnPBL3.RJTextBox();
            this.rjtbBD = new DoAnPBL3.RJTextBox();
            this.rjtbAddress = new DoAnPBL3.RJTextBox();
            this.rjtbSDT = new DoAnPBL3.RJTextBox();
            this.rjtbEmail = new DoAnPBL3.RJTextBox();
            this.rjcbGender = new DoAnPBL3.RJComboBox();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.rjbtnCancel = new DoAnPBL3.RJButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(356, 41);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DoAnPBL3.Properties.Resources.add;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(193, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm khách hàng mới";
            // 
            // lblNameNV
            // 
            this.lblNameNV.AutoSize = true;
            this.lblNameNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNV.Location = new System.Drawing.Point(13, 58);
            this.lblNameNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(81, 19);
            this.lblNameNV.TabIndex = 7;
            this.lblNameNV.Text = "Họ và tên";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.Location = new System.Drawing.Point(13, 116);
            this.lblBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(86, 19);
            this.lblBD.TabIndex = 8;
            this.lblBD.Text = "Ngày sinh";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(13, 183);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(73, 19);
            this.lblGender.TabIndex = 9;
            this.lblGender.Text = "Giới tính";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 247);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 19);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(13, 314);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(109, 19);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 382);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // rjtbNameNV
            // 
            this.rjtbNameNV.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbNameNV.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.rjtbNameNV.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtbNameNV.BorderRadius = 0;
            this.rjtbNameNV.BorderSize = 2;
            this.rjtbNameNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbNameNV.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbNameNV.Location = new System.Drawing.Point(137, 52);
            this.rjtbNameNV.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbNameNV.Multiline = false;
            this.rjtbNameNV.Name = "rjtbNameNV";
            this.rjtbNameNV.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbNameNV.PasswordChar = false;
            this.rjtbNameNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbNameNV.PlaceholderText = "Nhập họ và tên";
            this.rjtbNameNV.Size = new System.Drawing.Size(188, 30);
            this.rjtbNameNV.TabIndex = 13;
            this.rjtbNameNV.Texts = "";
            this.rjtbNameNV.UnderlinedStyle = false;
            // 
            // rjtbBD
            // 
            this.rjtbBD.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbBD.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.rjtbBD.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtbBD.BorderRadius = 0;
            this.rjtbBD.BorderSize = 2;
            this.rjtbBD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbBD.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbBD.Location = new System.Drawing.Point(137, 113);
            this.rjtbBD.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbBD.Multiline = false;
            this.rjtbBD.Name = "rjtbBD";
            this.rjtbBD.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbBD.PasswordChar = false;
            this.rjtbBD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbBD.PlaceholderText = "Nhập ngày sinh";
            this.rjtbBD.Size = new System.Drawing.Size(188, 30);
            this.rjtbBD.TabIndex = 14;
            this.rjtbBD.Texts = "";
            this.rjtbBD.UnderlinedStyle = false;
            // 
            // rjtbAddress
            // 
            this.rjtbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbAddress.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.rjtbAddress.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtbAddress.BorderRadius = 0;
            this.rjtbAddress.BorderSize = 2;
            this.rjtbAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbAddress.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbAddress.Location = new System.Drawing.Point(137, 243);
            this.rjtbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbAddress.Multiline = false;
            this.rjtbAddress.Name = "rjtbAddress";
            this.rjtbAddress.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbAddress.PasswordChar = false;
            this.rjtbAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbAddress.PlaceholderText = "Nhập địa chỉ";
            this.rjtbAddress.Size = new System.Drawing.Size(188, 30);
            this.rjtbAddress.TabIndex = 15;
            this.rjtbAddress.Texts = "";
            this.rjtbAddress.UnderlinedStyle = false;
            // 
            // rjtbSDT
            // 
            this.rjtbSDT.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbSDT.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.rjtbSDT.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtbSDT.BorderRadius = 0;
            this.rjtbSDT.BorderSize = 2;
            this.rjtbSDT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbSDT.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbSDT.Location = new System.Drawing.Point(137, 310);
            this.rjtbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbSDT.Multiline = false;
            this.rjtbSDT.Name = "rjtbSDT";
            this.rjtbSDT.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbSDT.PasswordChar = false;
            this.rjtbSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbSDT.PlaceholderText = "Nhập số điện thoại";
            this.rjtbSDT.Size = new System.Drawing.Size(188, 30);
            this.rjtbSDT.TabIndex = 16;
            this.rjtbSDT.Texts = "";
            this.rjtbSDT.UnderlinedStyle = false;
            // 
            // rjtbEmail
            // 
            this.rjtbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbEmail.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.rjtbEmail.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjtbEmail.BorderRadius = 0;
            this.rjtbEmail.BorderSize = 2;
            this.rjtbEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbEmail.Location = new System.Drawing.Point(137, 377);
            this.rjtbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbEmail.Multiline = false;
            this.rjtbEmail.Name = "rjtbEmail";
            this.rjtbEmail.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbEmail.PasswordChar = false;
            this.rjtbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbEmail.PlaceholderText = "Nhập Email";
            this.rjtbEmail.Size = new System.Drawing.Size(188, 30);
            this.rjtbEmail.TabIndex = 17;
            this.rjtbEmail.Texts = "";
            this.rjtbEmail.UnderlinedStyle = false;
            // 
            // rjcbGender
            // 
            this.rjcbGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjcbGender.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjcbGender.BorderSize = 2;
            this.rjcbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rjcbGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjcbGender.ForeColor = System.Drawing.Color.DarkGray;
            this.rjcbGender.IconColor = System.Drawing.Color.Blue;
            this.rjcbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Giới tính thứ 3"});
            this.rjcbGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbGender.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbGender.Location = new System.Drawing.Point(137, 174);
            this.rjcbGender.Margin = new System.Windows.Forms.Padding(2);
            this.rjcbGender.MinimumSize = new System.Drawing.Size(150, 24);
            this.rjcbGender.Name = "rjcbGender";
            this.rjcbGender.Padding = new System.Windows.Forms.Padding(2);
            this.rjcbGender.Size = new System.Drawing.Size(188, 36);
            this.rjcbGender.TabIndex = 18;
            this.rjcbGender.Texts = "Giới tính";
            // 
            // rjbtnOK
            // 
            this.rjbtnOK.BackColor = System.Drawing.Color.SeaGreen;
            this.rjbtnOK.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.rjbtnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnOK.BorderRadius = 15;
            this.rjbtnOK.BorderSize = 0;
            this.rjbtnOK.FlatAppearance.BorderSize = 0;
            this.rjbtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnOK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnOK.ForeColor = System.Drawing.Color.White;
            this.rjbtnOK.Location = new System.Drawing.Point(52, 465);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(113, 36);
            this.rjbtnOK.TabIndex = 19;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.rjbtnOK_Click);
            // 
            // rjbtnCancel
            // 
            this.rjbtnCancel.BackColor = System.Drawing.Color.DimGray;
            this.rjbtnCancel.BackgroundColor = System.Drawing.Color.DimGray;
            this.rjbtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnCancel.BorderRadius = 15;
            this.rjbtnCancel.BorderSize = 0;
            this.rjbtnCancel.FlatAppearance.BorderSize = 0;
            this.rjbtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnCancel.ForeColor = System.Drawing.Color.White;
            this.rjbtnCancel.Location = new System.Drawing.Point(193, 465);
            this.rjbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(113, 36);
            this.rjbtnCancel.TabIndex = 20;
            this.rjbtnCancel.Text = "Cancel";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            this.rjbtnCancel.Click += new System.EventHandler(this.rjbtnCancel_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.rjbtnCancel);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Controls.Add(this.rjcbGender);
            this.panelContainer.Controls.Add(this.rjtbEmail);
            this.panelContainer.Controls.Add(this.rjtbSDT);
            this.panelContainer.Controls.Add(this.rjtbAddress);
            this.panelContainer.Controls.Add(this.rjtbBD);
            this.panelContainer.Controls.Add(this.rjtbNameNV);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.lblSDT);
            this.panelContainer.Controls.Add(this.lblAddress);
            this.panelContainer.Controls.Add(this.lblGender);
            this.panelContainer.Controls.Add(this.lblBD);
            this.panelContainer.Controls.Add(this.lblNameNV);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(356, 524);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // FormAddKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 524);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddSach";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameNV;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private RJTextBox rjtbNameNV;
        private RJTextBox rjtbBD;
        private RJTextBox rjtbAddress;
        private RJTextBox rjtbSDT;
        private RJTextBox rjtbEmail;
        private RJComboBox rjcbGender;
        private RJButton rjbtnOK;
        private RJButton rjbtnCancel;
        private System.Windows.Forms.Panel panelContainer;
    }
}