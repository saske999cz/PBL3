
namespace DoAnPBL3
{
    partial class FormAddNV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNV));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnAvatar = new Guna.UI2.WinForms.Guna2Button();
            this.msgDateOfBirth = new System.Windows.Forms.Label();
            this.msgAge = new System.Windows.Forms.Label();
            this.msgGender = new System.Windows.Forms.Label();
            this.msgAddress = new System.Windows.Forms.Label();
            this.gunaDTP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.msgEmail = new System.Windows.Forms.Label();
            this.msgPhone = new System.Windows.Forms.Label();
            this.msgIDCard = new System.Windows.Forms.Label();
            this.msgName = new System.Windows.Forms.Label();
            this.rjcbbAddress = new DoAnPBL3.RJComboBox();
            this.rjcbbGender = new DoAnPBL3.RJComboBox();
            this.rjbtnCancel = new DoAnPBL3.RJButton();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.rjtbEmail = new DoAnPBL3.RJTextBox();
            this.rjtbCMND = new DoAnPBL3.RJTextBox();
            this.rjtbSDT = new DoAnPBL3.RJTextBox();
            this.rjtbNameNV = new DoAnPBL3.RJTextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.avatar = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.avatar);
            this.panelContainer.Controls.Add(this.btnAvatar);
            this.panelContainer.Controls.Add(this.msgDateOfBirth);
            this.panelContainer.Controls.Add(this.msgAge);
            this.panelContainer.Controls.Add(this.msgGender);
            this.panelContainer.Controls.Add(this.msgAddress);
            this.panelContainer.Controls.Add(this.gunaDTP);
            this.panelContainer.Controls.Add(this.msgEmail);
            this.panelContainer.Controls.Add(this.msgPhone);
            this.panelContainer.Controls.Add(this.msgIDCard);
            this.panelContainer.Controls.Add(this.msgName);
            this.panelContainer.Controls.Add(this.rjcbbAddress);
            this.panelContainer.Controls.Add(this.rjcbbGender);
            this.panelContainer.Controls.Add(this.rjbtnCancel);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Controls.Add(this.rjtbEmail);
            this.panelContainer.Controls.Add(this.rjtbCMND);
            this.panelContainer.Controls.Add(this.rjtbSDT);
            this.panelContainer.Controls.Add(this.rjtbNameNV);
            this.panelContainer.Controls.Add(this.lblCMND);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.lblSDT);
            this.panelContainer.Controls.Add(this.lblAddress);
            this.panelContainer.Controls.Add(this.lblGender);
            this.panelContainer.Controls.Add(this.lblBD);
            this.panelContainer.Controls.Add(this.lblNameNV);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(731, 611);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btnAvatar
            // 
            this.btnAvatar.DefaultAutoSize = true;
            this.btnAvatar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAvatar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAvatar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAvatar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAvatar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvatar.ForeColor = System.Drawing.Color.Black;
            this.btnAvatar.Location = new System.Drawing.Point(486, 61);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(87, 37);
            this.btnAvatar.TabIndex = 21;
            this.btnAvatar.Text = "Avatar";
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // msgDateOfBirth
            // 
            this.msgDateOfBirth.AutoSize = true;
            this.msgDateOfBirth.Location = new System.Drawing.Point(135, 166);
            this.msgDateOfBirth.Name = "msgDateOfBirth";
            this.msgDateOfBirth.Size = new System.Drawing.Size(0, 13);
            this.msgDateOfBirth.TabIndex = 20;
            // 
            // msgAge
            // 
            this.msgAge.AutoSize = true;
            this.msgAge.Location = new System.Drawing.Point(135, 153);
            this.msgAge.Name = "msgAge";
            this.msgAge.Size = new System.Drawing.Size(0, 13);
            this.msgAge.TabIndex = 19;
            // 
            // msgGender
            // 
            this.msgGender.AutoSize = true;
            this.msgGender.Location = new System.Drawing.Point(138, 217);
            this.msgGender.Name = "msgGender";
            this.msgGender.Size = new System.Drawing.Size(0, 13);
            this.msgGender.TabIndex = 18;
            // 
            // msgAddress
            // 
            this.msgAddress.AutoSize = true;
            this.msgAddress.Location = new System.Drawing.Point(138, 341);
            this.msgAddress.Name = "msgAddress";
            this.msgAddress.Size = new System.Drawing.Size(0, 13);
            this.msgAddress.TabIndex = 18;
            // 
            // gunaDTP
            // 
            this.gunaDTP.Checked = true;
            this.gunaDTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gunaDTP.Location = new System.Drawing.Point(135, 113);
            this.gunaDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDTP.Name = "gunaDTP";
            this.gunaDTP.Size = new System.Drawing.Size(188, 30);
            this.gunaDTP.TabIndex = 17;
            this.gunaDTP.Value = new System.DateTime(2022, 5, 5, 20, 47, 40, 103);
            // 
            // msgEmail
            // 
            this.msgEmail.AutoSize = true;
            this.msgEmail.Location = new System.Drawing.Point(136, 457);
            this.msgEmail.Name = "msgEmail";
            this.msgEmail.Size = new System.Drawing.Size(0, 13);
            this.msgEmail.TabIndex = 16;
            // 
            // msgPhone
            // 
            this.msgPhone.AutoSize = true;
            this.msgPhone.Location = new System.Drawing.Point(138, 395);
            this.msgPhone.Name = "msgPhone";
            this.msgPhone.Size = new System.Drawing.Size(0, 13);
            this.msgPhone.TabIndex = 16;
            // 
            // msgIDCard
            // 
            this.msgIDCard.AutoSize = true;
            this.msgIDCard.Location = new System.Drawing.Point(138, 275);
            this.msgIDCard.Name = "msgIDCard";
            this.msgIDCard.Size = new System.Drawing.Size(0, 13);
            this.msgIDCard.TabIndex = 16;
            // 
            // msgName
            // 
            this.msgName.AutoSize = true;
            this.msgName.Location = new System.Drawing.Point(138, 95);
            this.msgName.Name = "msgName";
            this.msgName.Size = new System.Drawing.Size(0, 13);
            this.msgName.TabIndex = 16;
            // 
            // rjcbbAddress
            // 
            this.rjcbbAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjcbbAddress.BorderColor = System.Drawing.Color.HotPink;
            this.rjcbbAddress.BorderSize = 2;
            this.rjcbbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbbAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjcbbAddress.ForeColor = System.Drawing.Color.DarkGray;
            this.rjcbbAddress.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbbAddress.Items.AddRange(new object[] {
            "Quận Thanh Khê",
            "Quận Hải Châu",
            "Quận Cẩm Lệ",
            "Quận Sơn Trà",
            "Quận Ngũ Hành Sơn",
            "Quận Liên Chiểu",
            "Huyện Hoàng Sa",
            "Huyện Hòa Vang"});
            this.rjcbbAddress.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbbAddress.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbbAddress.Location = new System.Drawing.Point(135, 302);
            this.rjcbbAddress.MinimumSize = new System.Drawing.Size(188, 29);
            this.rjcbbAddress.Name = "rjcbbAddress";
            this.rjcbbAddress.Padding = new System.Windows.Forms.Padding(2);
            this.rjcbbAddress.Size = new System.Drawing.Size(188, 32);
            this.rjcbbAddress.TabIndex = 15;
            this.rjcbbAddress.Texts = "Địa chỉ";
            // 
            // rjcbbGender
            // 
            this.rjcbbGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjcbbGender.BorderColor = System.Drawing.Color.HotPink;
            this.rjcbbGender.BorderSize = 2;
            this.rjcbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjcbbGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjcbbGender.ForeColor = System.Drawing.Color.DarkGray;
            this.rjcbbGender.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjcbbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Giới tính thứ 3"});
            this.rjcbbGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjcbbGender.ListTextColor = System.Drawing.Color.DimGray;
            this.rjcbbGender.Location = new System.Drawing.Point(135, 182);
            this.rjcbbGender.MinimumSize = new System.Drawing.Size(188, 29);
            this.rjcbbGender.Name = "rjcbbGender";
            this.rjcbbGender.Padding = new System.Windows.Forms.Padding(2);
            this.rjcbbGender.Size = new System.Drawing.Size(188, 32);
            this.rjcbbGender.TabIndex = 15;
            this.rjcbbGender.Texts = "Giới tính";
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
            this.rjbtnCancel.Location = new System.Drawing.Point(411, 536);
            this.rjbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(113, 36);
            this.rjbtnCancel.TabIndex = 14;
            this.rjbtnCancel.Text = "Cancel";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            this.rjbtnCancel.Click += new System.EventHandler(this.rjbtnCancel_Click);
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
            this.rjbtnOK.Location = new System.Drawing.Point(210, 536);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(113, 36);
            this.rjbtnOK.TabIndex = 13;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.rjbtnOK_Click);
            // 
            // rjtbEmail
            // 
            this.rjtbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtbEmail.BorderRadius = 0;
            this.rjtbEmail.BorderSize = 2;
            this.rjtbEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbEmail.Location = new System.Drawing.Point(135, 423);
            this.rjtbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbEmail.Multiline = false;
            this.rjtbEmail.Name = "rjtbEmail";
            this.rjtbEmail.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbEmail.PasswordChar = false;
            this.rjtbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbEmail.PlaceholderText = "Nhập Email";
            this.rjtbEmail.Size = new System.Drawing.Size(188, 30);
            this.rjtbEmail.TabIndex = 12;
            this.rjtbEmail.Texts = "";
            this.rjtbEmail.UnderlinedStyle = false;
            // 
            // rjtbCMND
            // 
            this.rjtbCMND.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbCMND.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtbCMND.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtbCMND.BorderRadius = 0;
            this.rjtbCMND.BorderSize = 2;
            this.rjtbCMND.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbCMND.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbCMND.Location = new System.Drawing.Point(135, 241);
            this.rjtbCMND.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbCMND.Multiline = false;
            this.rjtbCMND.Name = "rjtbCMND";
            this.rjtbCMND.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbCMND.PasswordChar = false;
            this.rjtbCMND.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbCMND.PlaceholderText = "Nhập CMND";
            this.rjtbCMND.Size = new System.Drawing.Size(188, 30);
            this.rjtbCMND.TabIndex = 9;
            this.rjtbCMND.Texts = "";
            this.rjtbCMND.UnderlinedStyle = false;
            // 
            // rjtbSDT
            // 
            this.rjtbSDT.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbSDT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtbSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtbSDT.BorderRadius = 0;
            this.rjtbSDT.BorderSize = 2;
            this.rjtbSDT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbSDT.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbSDT.Location = new System.Drawing.Point(135, 361);
            this.rjtbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbSDT.Multiline = false;
            this.rjtbSDT.Name = "rjtbSDT";
            this.rjtbSDT.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbSDT.PasswordChar = false;
            this.rjtbSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbSDT.PlaceholderText = "Nhập số điện thoại";
            this.rjtbSDT.Size = new System.Drawing.Size(188, 30);
            this.rjtbSDT.TabIndex = 11;
            this.rjtbSDT.Texts = "";
            this.rjtbSDT.UnderlinedStyle = false;
            // 
            // rjtbNameNV
            // 
            this.rjtbNameNV.BackColor = System.Drawing.SystemColors.Window;
            this.rjtbNameNV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjtbNameNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjtbNameNV.BorderRadius = 0;
            this.rjtbNameNV.BorderSize = 2;
            this.rjtbNameNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbNameNV.ForeColor = System.Drawing.Color.DimGray;
            this.rjtbNameNV.Location = new System.Drawing.Point(135, 61);
            this.rjtbNameNV.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbNameNV.Multiline = false;
            this.rjtbNameNV.Name = "rjtbNameNV";
            this.rjtbNameNV.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbNameNV.PasswordChar = false;
            this.rjtbNameNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjtbNameNV.PlaceholderText = "Nhập họ và tên";
            this.rjtbNameNV.Size = new System.Drawing.Size(188, 30);
            this.rjtbNameNV.TabIndex = 7;
            this.rjtbNameNV.Texts = "";
            this.rjtbNameNV.UnderlinedStyle = false;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(11, 252);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(58, 19);
            this.lblCMND.TabIndex = 5;
            this.lblCMND.Text = "CMND";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 428);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(13, 365);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(109, 19);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 302);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 19);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(13, 195);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(73, 19);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới tính";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.Location = new System.Drawing.Point(11, 124);
            this.lblBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(86, 19);
            this.lblBD.TabIndex = 2;
            this.lblBD.Text = "Ngày sinh";
            // 
            // lblNameNV
            // 
            this.lblNameNV.AutoSize = true;
            this.lblNameNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNV.Location = new System.Drawing.Point(13, 66);
            this.lblNameNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(81, 19);
            this.lblNameNV.TabIndex = 1;
            this.lblNameNV.Text = "Họ và tên";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(731, 41);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(176, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm nhân viên mới";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.label1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.pictureBox1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.White;
            this.avatar.Location = new System.Drawing.Point(396, 113);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(274, 334);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 22;
            this.avatar.TabStop = false;
            // 
            // FormAddNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(731, 611);
            this.Controls.Add(this.panelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameNV;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private RJTextBox rjtbEmail;
        private RJTextBox rjtbSDT;
        private RJTextBox rjtbNameNV;
        private RJButton rjbtnCancel;
        private RJButton rjbtnOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJTextBox rjtbCMND;
        private System.Windows.Forms.Label lblCMND;
        private RJComboBox rjcbbGender;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Label msgPhone;
        private System.Windows.Forms.Label msgIDCard;
        private System.Windows.Forms.Label msgName;
        private RJComboBox rjcbbAddress;
        private System.Windows.Forms.Label msgEmail;
        private Guna.UI2.WinForms.Guna2DateTimePicker gunaDTP;
        private System.Windows.Forms.Label msgGender;
        private System.Windows.Forms.Label msgAddress;
        private System.Windows.Forms.Label msgAge;
        private System.Windows.Forms.Label msgDateOfBirth;
        private Guna.UI2.WinForms.Guna2Button btnAvatar;
        private System.Windows.Forms.PictureBox avatar;
    }
}