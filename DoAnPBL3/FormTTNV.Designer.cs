
namespace DoAnPBL3
{
    partial class FormTTNV
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tbEmailNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSDTNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddressNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCMNDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBD = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGenderNV = new DoAnPBL3.RJComboBox();
            this.rjbtnCancel = new DoAnPBL3.RJButton();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(812, 41);
            this.panelTitleBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panelContainer.Controls.Add(this.guna2PictureBox1);
            this.panelContainer.Controls.Add(this.tbEmailNV);
            this.panelContainer.Controls.Add(this.tbSDTNV);
            this.panelContainer.Controls.Add(this.tbAddressNV);
            this.panelContainer.Controls.Add(this.tbCMNDNV);
            this.panelContainer.Controls.Add(this.tbBD);
            this.panelContainer.Controls.Add(this.tbNameNV);
            this.panelContainer.Controls.Add(this.cbGenderNV);
            this.panelContainer.Controls.Add(this.rjbtnCancel);
            this.panelContainer.Controls.Add(this.lblCMND);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.lblSDT);
            this.panelContainer.Controls.Add(this.lblAddress);
            this.panelContainer.Controls.Add(this.lblGender);
            this.panelContainer.Controls.Add(this.lblBD);
            this.panelContainer.Controls.Add(this.lblNameNV);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(812, 645);
            this.panelContainer.TabIndex = 3;
            // 
            // tbEmailNV
            // 
            this.tbEmailNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.BorderRadius = 6;
            this.tbEmailNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmailNV.DefaultText = "";
            this.tbEmailNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.Enabled = false;
            this.tbEmailNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbEmailNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailNV.Location = new System.Drawing.Point(378, 435);
            this.tbEmailNV.Name = "tbEmailNV";
            this.tbEmailNV.PasswordChar = '\0';
            this.tbEmailNV.PlaceholderText = "Email";
            this.tbEmailNV.SelectedText = "";
            this.tbEmailNV.Size = new System.Drawing.Size(409, 30);
            this.tbEmailNV.TabIndex = 21;
            // 
            // tbSDTNV
            // 
            this.tbSDTNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.BorderRadius = 6;
            this.tbSDTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSDTNV.DefaultText = "";
            this.tbSDTNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.Enabled = false;
            this.tbSDTNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSDTNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTNV.Location = new System.Drawing.Point(378, 369);
            this.tbSDTNV.Name = "tbSDTNV";
            this.tbSDTNV.PasswordChar = '\0';
            this.tbSDTNV.PlaceholderText = "Số điện thoại";
            this.tbSDTNV.SelectedText = "";
            this.tbSDTNV.Size = new System.Drawing.Size(409, 30);
            this.tbSDTNV.TabIndex = 20;
            // 
            // tbAddressNV
            // 
            this.tbAddressNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.BorderRadius = 6;
            this.tbAddressNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddressNV.DefaultText = "";
            this.tbAddressNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.Enabled = false;
            this.tbAddressNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAddressNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressNV.Location = new System.Drawing.Point(378, 303);
            this.tbAddressNV.Name = "tbAddressNV";
            this.tbAddressNV.PasswordChar = '\0';
            this.tbAddressNV.PlaceholderText = "Địa chỉ";
            this.tbAddressNV.SelectedText = "";
            this.tbAddressNV.Size = new System.Drawing.Size(409, 30);
            this.tbAddressNV.TabIndex = 19;
            // 
            // tbCMNDNV
            // 
            this.tbCMNDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.BorderRadius = 6;
            this.tbCMNDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMNDNV.DefaultText = "";
            this.tbCMNDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.Enabled = false;
            this.tbCMNDNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCMNDNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDNV.Location = new System.Drawing.Point(378, 235);
            this.tbCMNDNV.Name = "tbCMNDNV";
            this.tbCMNDNV.PasswordChar = '\0';
            this.tbCMNDNV.PlaceholderText = "CMND";
            this.tbCMNDNV.SelectedText = "";
            this.tbCMNDNV.Size = new System.Drawing.Size(409, 30);
            this.tbCMNDNV.TabIndex = 18;
            // 
            // tbBD
            // 
            this.tbBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.BorderRadius = 6;
            this.tbBD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBD.DefaultText = "";
            this.tbBD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.Enabled = false;
            this.tbBD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Location = new System.Drawing.Point(378, 110);
            this.tbBD.Name = "tbBD";
            this.tbBD.PasswordChar = '\0';
            this.tbBD.PlaceholderText = "Ngày sinh";
            this.tbBD.SelectedText = "";
            this.tbBD.Size = new System.Drawing.Size(409, 30);
            this.tbBD.TabIndex = 17;
            // 
            // tbNameNV
            // 
            this.tbNameNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.BorderRadius = 6;
            this.tbNameNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameNV.DefaultText = "";
            this.tbNameNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.Enabled = false;
            this.tbNameNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameNV.Location = new System.Drawing.Point(378, 48);
            this.tbNameNV.Name = "tbNameNV";
            this.tbNameNV.PasswordChar = '\0';
            this.tbNameNV.PlaceholderText = "Họ và tên";
            this.tbNameNV.SelectedText = "";
            this.tbNameNV.Size = new System.Drawing.Size(409, 30);
            this.tbNameNV.TabIndex = 16;
            // 
            // cbGenderNV
            // 
            this.cbGenderNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.cbGenderNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.cbGenderNV.BorderSize = 2;
            this.cbGenderNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenderNV.Enabled = false;
            this.cbGenderNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenderNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbGenderNV.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbGenderNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Giới tính thứ 3"});
            this.cbGenderNV.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.cbGenderNV.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbGenderNV.Location = new System.Drawing.Point(378, 172);
            this.cbGenderNV.MinimumSize = new System.Drawing.Size(188, 29);
            this.cbGenderNV.Name = "cbGenderNV";
            this.cbGenderNV.Padding = new System.Windows.Forms.Padding(2);
            this.cbGenderNV.Size = new System.Drawing.Size(409, 32);
            this.cbGenderNV.TabIndex = 15;
            this.cbGenderNV.Texts = "Giới tính";
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
            this.rjbtnCancel.Location = new System.Drawing.Point(342, 574);
            this.rjbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(145, 36);
            this.rjbtnCancel.TabIndex = 14;
            this.rjbtnCancel.Text = "Hủy";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCMND.Location = new System.Drawing.Point(286, 241);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(54, 18);
            this.lblCMND.TabIndex = 5;
            this.lblCMND.Text = "CMND";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(286, 440);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSDT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSDT.Location = new System.Drawing.Point(286, 373);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(80, 18);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(286, 306);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 18);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGender.Location = new System.Drawing.Point(286, 177);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 18);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới tính";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBD.Location = new System.Drawing.Point(286, 115);
            this.lblBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(77, 18);
            this.lblBD.TabIndex = 2;
            this.lblBD.Text = "Ngày sinh";
            // 
            // lblNameNV
            // 
            this.lblNameNV.AutoSize = true;
            this.lblNameNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameNV.Location = new System.Drawing.Point(286, 53);
            this.lblNameNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(76, 18);
            this.lblNameNV.TabIndex = 1;
            this.lblNameNV.Text = "Họ và tên";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.cbGenderNV;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 51);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(242, 233);
            this.guna2PictureBox1.TabIndex = 46;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.user_info;
            this.pictureBox1.Location = new System.Drawing.Point(173, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelContainer;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.panelTitleBar;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // FormTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 686);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTTNV";
            this.Text = "FormTTNV";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private RJComboBox cbGenderNV;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblNameNV;
        private Guna.UI2.WinForms.Guna2TextBox tbNameNV;
        private Guna.UI2.WinForms.Guna2TextBox tbBD;
        private Guna.UI2.WinForms.Guna2TextBox tbCMNDNV;
        private Guna.UI2.WinForms.Guna2TextBox tbSDTNV;
        private Guna.UI2.WinForms.Guna2TextBox tbAddressNV;
        private Guna.UI2.WinForms.Guna2TextBox tbEmailNV;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private RJButton rjbtnCancel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}