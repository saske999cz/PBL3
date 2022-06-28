
namespace DoAnPBL3
{
    partial class FormHoaDonKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dgvQLHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBill = new System.Windows.Forms.Panel();
            this.totalBill = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDKH = new System.Windows.Forms.Label();
            this.msgValidateEmail = new System.Windows.Forms.Label();
            this.tbNameKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.lblNameKH = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).BeginInit();
            this.panelBill.SuspendLayout();
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
            this.panelTitleBar.Size = new System.Drawing.Size(828, 41);
            this.panelTitleBar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(180, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn khách hàng";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelContainer.Controls.Add(this.tbTotalPrice);
            this.panelContainer.Controls.Add(this.lblTotalPrice);
            this.panelContainer.Controls.Add(this.dgvQLHD);
            this.panelContainer.Controls.Add(this.panelBill);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.tbMaKH);
            this.panelContainer.Controls.Add(this.lblIDKH);
            this.panelContainer.Controls.Add(this.msgValidateEmail);
            this.panelContainer.Controls.Add(this.tbNameKH);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Controls.Add(this.lblNameKH);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(828, 707);
            this.panelContainer.TabIndex = 5;
            // 
            // dgvQLHD
            // 
            this.dgvQLHD.AllowUserToAddRows = false;
            this.dgvQLHD.AllowUserToDeleteRows = false;
            this.dgvQLHD.AllowUserToResizeColumns = false;
            this.dgvQLHD.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQLHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLHD.ColumnHeadersHeight = 30;
            this.dgvQLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Order,
            this.OrderDate,
            this.NameEmployee,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLHD.EnableHeadersVisualStyles = false;
            this.dgvQLHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLHD.Location = new System.Drawing.Point(6, 158);
            this.dgvQLHD.Name = "dgvQLHD";
            this.dgvQLHD.ReadOnly = true;
            this.dgvQLHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLHD.RowHeadersVisible = false;
            this.dgvQLHD.RowHeadersWidth = 60;
            this.dgvQLHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLHD.Size = new System.Drawing.Size(816, 422);
            this.dgvQLHD.TabIndex = 58;
            this.dgvQLHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLHD.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLHD.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLHD.ThemeStyle.ReadOnly = true;
            this.dgvQLHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLHD.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLHD.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLHD_RowHeaderMouseClick);
            // 
            // ID_Order
            // 
            this.ID_Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Order.DataPropertyName = "ID_Order";
            this.ID_Order.FillWeight = 53.4267F;
            this.ID_Order.HeaderText = "ID Hóa đơn";
            this.ID_Order.Name = "ID_Order";
            this.ID_Order.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.FillWeight = 101.5228F;
            this.OrderDate.HeaderText = "Ngày mua";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // NameEmployee
            // 
            this.NameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameEmployee.DataPropertyName = "NameEmployee";
            this.NameEmployee.FillWeight = 122.5252F;
            this.NameEmployee.HeaderText = "Thu ngân";
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "Total";
            this.Total.FillWeight = 122.5252F;
            this.Total.HeaderText = "Tổng tiền";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // panelBill
            // 
            this.panelBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panelBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBill.Controls.Add(this.totalBill);
            this.panelBill.Controls.Add(this.lblTotalBill);
            this.panelBill.Location = new System.Drawing.Point(615, 12);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(200, 89);
            this.panelBill.TabIndex = 57;
            // 
            // totalBill
            // 
            this.totalBill.AutoSize = true;
            this.totalBill.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBill.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.totalBill.Location = new System.Drawing.Point(93, 46);
            this.totalBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalBill.Name = "totalBill";
            this.totalBill.Size = new System.Drawing.Size(16, 18);
            this.totalBill.TabIndex = 57;
            this.totalBill.Text = "0";
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBill.Location = new System.Drawing.Point(37, 9);
            this.lblTotalBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(129, 18);
            this.lblTotalBill.TabIndex = 56;
            this.lblTotalBill.Text = "Tổng số hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, -19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 55;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Animated = true;
            this.tbMaKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbMaKH.BorderRadius = 6;
            this.tbMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaKH.DefaultText = "";
            this.tbMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbMaKH.Enabled = false;
            this.tbMaKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKH.Location = new System.Drawing.Point(180, 16);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.PasswordChar = '\0';
            this.tbMaKH.PlaceholderText = "Mã khách hàng";
            this.tbMaKH.SelectedText = "";
            this.tbMaKH.Size = new System.Drawing.Size(409, 30);
            this.tbMaKH.TabIndex = 0;
            // 
            // lblIDKH
            // 
            this.lblIDKH.AutoSize = true;
            this.lblIDKH.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIDKH.Location = new System.Drawing.Point(18, 21);
            this.lblIDKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDKH.Name = "lblIDKH";
            this.lblIDKH.Size = new System.Drawing.Size(114, 18);
            this.lblIDKH.TabIndex = 52;
            this.lblIDKH.Text = "Mã khách hàng";
            // 
            // msgValidateEmail
            // 
            this.msgValidateEmail.AutoSize = true;
            this.msgValidateEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateEmail.Location = new System.Drawing.Point(396, 212);
            this.msgValidateEmail.Name = "msgValidateEmail";
            this.msgValidateEmail.Size = new System.Drawing.Size(0, 16);
            this.msgValidateEmail.TabIndex = 50;
            // 
            // tbNameKH
            // 
            this.tbNameKH.Animated = true;
            this.tbNameKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.BorderRadius = 6;
            this.tbNameKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameKH.DefaultText = "";
            this.tbNameKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.Enabled = false;
            this.tbNameKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Location = new System.Drawing.Point(180, 71);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.PasswordChar = '\0';
            this.tbNameKH.PlaceholderText = "Họ và tên khách hàng";
            this.tbNameKH.SelectedText = "";
            this.tbNameKH.Size = new System.Drawing.Size(409, 30);
            this.tbNameKH.TabIndex = 1;
            // 
            // rjbtnOK
            // 
            this.rjbtnOK.BackColor = System.Drawing.Color.SeaGreen;
            this.rjbtnOK.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.rjbtnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnOK.BorderRadius = 15;
            this.rjbtnOK.BorderSize = 0;
            this.rjbtnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnOK.FlatAppearance.BorderSize = 0;
            this.rjbtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnOK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnOK.ForeColor = System.Drawing.Color.White;
            this.rjbtnOK.Location = new System.Drawing.Point(342, 634);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 11;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.RjbtnOK_Click);
            // 
            // lblNameKH
            // 
            this.lblNameKH.AutoSize = true;
            this.lblNameKH.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameKH.Location = new System.Drawing.Point(14, 74);
            this.lblNameKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameKH.Name = "lblNameKH";
            this.lblNameKH.Size = new System.Drawing.Size(161, 18);
            this.lblNameKH.TabIndex = 1;
            this.lblNameKH.Text = "Họ và tên khách hàng";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.White;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitleBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Animated = true;
            this.tbTotalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbTotalPrice.BorderRadius = 6;
            this.tbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotalPrice.DefaultText = "";
            this.tbTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbTotalPrice.Enabled = false;
            this.tbTotalPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalPrice.Location = new System.Drawing.Point(694, 602);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.PasswordChar = '\0';
            this.tbTotalPrice.PlaceholderText = "Tổng tiền";
            this.tbTotalPrice.SelectedText = "";
            this.tbTotalPrice.Size = new System.Drawing.Size(121, 30);
            this.tbTotalPrice.TabIndex = 59;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalPrice.Location = new System.Drawing.Point(612, 607);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(76, 18);
            this.lblTotalPrice.TabIndex = 60;
            this.lblTotalPrice.Text = "Tổng tiền";
            // 
            // FormHoaDonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 748);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDonKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDonKhachHang";
            this.Load += new System.EventHandler(this.FormHoaDonKhachHang_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).EndInit();
            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbMaKH;
        private System.Windows.Forms.Label lblIDKH;
        private System.Windows.Forms.Label msgValidateEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbNameKH;
        private RJButton rjbtnOK;
        private System.Windows.Forms.Label lblNameKH;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Label totalBill;
        private System.Windows.Forms.Label lblTotalBill;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLHD;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2TextBox tbTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}