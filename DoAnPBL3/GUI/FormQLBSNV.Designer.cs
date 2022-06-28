
namespace DoAnPBL3
{
    partial class FormQLBSNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLBSNV));
            this.xuiSegmentSach = new XanderUI.XUISegment();
            this.totalEnglishBooks = new System.Windows.Forms.Label();
            this.lblTotalEnglishBook = new System.Windows.Forms.Label();
            this.totalVietnameseBooks = new System.Windows.Forms.Label();
            this.lblTotalVietnameseBook = new System.Windows.Forms.Label();
            this.totalBooks = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjbtnAddCart = new DoAnPBL3.RJButton();
            this.rjbtnOrder = new DoAnPBL3.RJButton();
            this.dgvQLBSNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NotificationCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblNotificationCounter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTKS = new Guna.UI2.WinForms.Guna2Button();
            this.rjtbTKS = new DoAnPBL3.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiSegmentSach
            // 
            this.xuiSegmentSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiSegmentSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegmentSach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSegmentSach.Items = "Tất cả, Tiếng Việt , Tiếng Anh";
            this.xuiSegmentSach.Location = new System.Drawing.Point(513, 130);
            this.xuiSegmentSach.Margin = new System.Windows.Forms.Padding(2);
            this.xuiSegmentSach.Name = "xuiSegmentSach";
            this.xuiSegmentSach.SegmentActiveTextColor = System.Drawing.SystemColors.Highlight;
            this.xuiSegmentSach.SegmentBackColor = System.Drawing.Color.CornflowerBlue;
            this.xuiSegmentSach.SegmentColor = System.Drawing.Color.Blue;
            this.xuiSegmentSach.SegmentInactiveTextColor = System.Drawing.Color.White;
            this.xuiSegmentSach.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuiSegmentSach.SelectedIndex = 0;
            this.xuiSegmentSach.Size = new System.Drawing.Size(314, 34);
            this.xuiSegmentSach.TabIndex = 35;
            this.xuiSegmentSach.Click += new System.EventHandler(this.XuiSegmentSach_Click);
            // 
            // totalEnglishBooks
            // 
            this.totalEnglishBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalEnglishBooks.AutoSize = true;
            this.totalEnglishBooks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEnglishBooks.ForeColor = System.Drawing.Color.White;
            this.totalEnglishBooks.Location = new System.Drawing.Point(818, 56);
            this.totalEnglishBooks.Name = "totalEnglishBooks";
            this.totalEnglishBooks.Size = new System.Drawing.Size(29, 16);
            this.totalEnglishBooks.TabIndex = 61;
            this.totalEnglishBooks.Text = "100";
            // 
            // lblTotalEnglishBook
            // 
            this.lblTotalEnglishBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEnglishBook.AutoSize = true;
            this.lblTotalEnglishBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnglishBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalEnglishBook.Location = new System.Drawing.Point(774, 25);
            this.lblTotalEnglishBook.Name = "lblTotalEnglishBook";
            this.lblTotalEnglishBook.Size = new System.Drawing.Size(123, 16);
            this.lblTotalEnglishBook.TabIndex = 60;
            this.lblTotalEnglishBook.Text = "Số sách tiếng Anh";
            // 
            // totalVietnameseBooks
            // 
            this.totalVietnameseBooks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalVietnameseBooks.AutoSize = true;
            this.totalVietnameseBooks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVietnameseBooks.ForeColor = System.Drawing.Color.White;
            this.totalVietnameseBooks.Location = new System.Drawing.Point(452, 56);
            this.totalVietnameseBooks.Name = "totalVietnameseBooks";
            this.totalVietnameseBooks.Size = new System.Drawing.Size(29, 16);
            this.totalVietnameseBooks.TabIndex = 59;
            this.totalVietnameseBooks.Text = "100";
            // 
            // lblTotalVietnameseBook
            // 
            this.lblTotalVietnameseBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalVietnameseBook.AutoSize = true;
            this.lblTotalVietnameseBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVietnameseBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalVietnameseBook.Location = new System.Drawing.Point(409, 25);
            this.lblTotalVietnameseBook.Name = "lblTotalVietnameseBook";
            this.lblTotalVietnameseBook.Size = new System.Drawing.Size(123, 16);
            this.lblTotalVietnameseBook.TabIndex = 58;
            this.lblTotalVietnameseBook.Text = "Số sách tiếng Việt";
            // 
            // totalBooks
            // 
            this.totalBooks.AutoSize = true;
            this.totalBooks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBooks.ForeColor = System.Drawing.Color.White;
            this.totalBooks.Location = new System.Drawing.Point(86, 56);
            this.totalBooks.Name = "totalBooks";
            this.totalBooks.Size = new System.Drawing.Size(29, 16);
            this.totalBooks.TabIndex = 57;
            this.totalBooks.Text = "100";
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.AutoSize = true;
            this.lblTotalBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalBook.Location = new System.Drawing.Point(30, 25);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(155, 16);
            this.lblTotalBook.TabIndex = 56;
            this.lblTotalBook.Text = "Tổng số sách đang bán";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this.xuiSegmentSach;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rjbtnOrder);
            this.panel1.Controls.Add(this.rjbtnAddCart);
            this.panel1.Location = new System.Drawing.Point(828, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 97);
            this.panel1.TabIndex = 66;
            // 
            // rjbtnAddCart
            // 
            this.rjbtnAddCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjbtnAddCart.BackColor = System.Drawing.Color.DodgerBlue;
            this.rjbtnAddCart.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.rjbtnAddCart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnAddCart.BorderRadius = 20;
            this.rjbtnAddCart.BorderSize = 0;
            this.rjbtnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnAddCart.FlatAppearance.BorderSize = 0;
            this.rjbtnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnAddCart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnAddCart.ForeColor = System.Drawing.Color.White;
            this.rjbtnAddCart.Image = global::DoAnPBL3.Properties.Resources.icons8_add_shopping_cart_30px;
            this.rjbtnAddCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjbtnAddCart.Location = new System.Drawing.Point(0, 3);
            this.rjbtnAddCart.Name = "rjbtnAddCart";
            this.rjbtnAddCart.Padding = new System.Windows.Forms.Padding(18, 0, 16, 0);
            this.rjbtnAddCart.Size = new System.Drawing.Size(150, 40);
            this.rjbtnAddCart.TabIndex = 65;
            this.rjbtnAddCart.Text = "Thêm vào giỏ hàng";
            this.rjbtnAddCart.TextColor = System.Drawing.Color.White;
            this.rjbtnAddCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnAddCart.UseVisualStyleBackColor = false;
            this.rjbtnAddCart.Click += new System.EventHandler(this.RjbtnAddCart_Click);
            // 
            // rjbtnOrder
            // 
            this.rjbtnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjbtnOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.rjbtnOrder.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.rjbtnOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnOrder.BorderRadius = 20;
            this.rjbtnOrder.BorderSize = 0;
            this.rjbtnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnOrder.FlatAppearance.BorderSize = 0;
            this.rjbtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnOrder.ForeColor = System.Drawing.Color.White;
            this.rjbtnOrder.Image = global::DoAnPBL3.Properties.Resources.icons8_buying_30;
            this.rjbtnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjbtnOrder.Location = new System.Drawing.Point(0, 54);
            this.rjbtnOrder.Name = "rjbtnOrder";
            this.rjbtnOrder.Size = new System.Drawing.Size(150, 40);
            this.rjbtnOrder.TabIndex = 39;
            this.rjbtnOrder.Text = "Xem giỏ hàng";
            this.rjbtnOrder.TextColor = System.Drawing.Color.White;
            this.rjbtnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnOrder.UseVisualStyleBackColor = false;
            this.rjbtnOrder.Click += new System.EventHandler(this.RjbtnOrder_Click);
            // 
            // dgvQLBSNV
            // 
            this.dgvQLBSNV.AllowUserToAddRows = false;
            this.dgvQLBSNV.AllowUserToDeleteRows = false;
            this.dgvQLBSNV.AllowUserToResizeColumns = false;
            this.dgvQLBSNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQLBSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLBSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLBSNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQLBSNV.ColumnHeadersHeight = 30;
            this.dgvQLBSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Book,
            this.NameBook,
            this.PublishDate,
            this.NameAuthor,
            this.NameLanguage,
            this.NameGenre,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvQLBSNV.EnableHeadersVisualStyles = false;
            this.dgvQLBSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLBSNV.Location = new System.Drawing.Point(6, 169);
            this.dgvQLBSNV.Name = "dgvQLBSNV";
            this.dgvQLBSNV.ReadOnly = true;
            this.dgvQLBSNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBSNV.RowHeadersVisible = false;
            this.dgvQLBSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBSNV.Size = new System.Drawing.Size(816, 413);
            this.dgvQLBSNV.TabIndex = 67;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLBSNV.ThemeStyle.ReadOnly = true;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLBSNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLBSNV.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLBSNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLBSNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLBSNV_RowHeaderMouseClick);
            // 
            // NotificationCircle
            // 
            this.NotificationCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NotificationCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NotificationCircle.DisabledState.FillColor = System.Drawing.Color.Firebrick;
            this.NotificationCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NotificationCircle.Enabled = false;
            this.NotificationCircle.FillColor = System.Drawing.Color.Firebrick;
            this.NotificationCircle.Font = new System.Drawing.Font("Arial", 5.25F);
            this.NotificationCircle.ForeColor = System.Drawing.Color.White;
            this.NotificationCircle.Location = new System.Drawing.Point(914, 118);
            this.NotificationCircle.Name = "NotificationCircle";
            this.NotificationCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.NotificationCircle.Size = new System.Drawing.Size(28, 28);
            this.NotificationCircle.TabIndex = 69;
            // 
            // lblNotificationCounter
            // 
            this.lblNotificationCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificationCounter.AutoSize = true;
            this.lblNotificationCounter.BackColor = System.Drawing.Color.Firebrick;
            this.lblNotificationCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotificationCounter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationCounter.ForeColor = System.Drawing.Color.White;
            this.lblNotificationCounter.Location = new System.Drawing.Point(922, 125);
            this.lblNotificationCounter.Name = "lblNotificationCounter";
            this.lblNotificationCounter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotificationCounter.Size = new System.Drawing.Size(13, 14);
            this.lblNotificationCounter.TabIndex = 70;
            this.lblNotificationCounter.Text = "0";
            this.lblNotificationCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::DoAnPBL3.Properties.Resources.icons8_shopping_cart_52;
            this.pictureBox4.Location = new System.Drawing.Point(854, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(99, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 68;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(191, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.united_kingdom_flag;
            this.pictureBox1.Location = new System.Drawing.Point(895, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.vietnam_flag;
            this.pictureBox2.Location = new System.Drawing.Point(530, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // btnTKS
            // 
            this.btnTKS.BorderRadius = 15;
            this.btnTKS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKS.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTKS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTKS.ForeColor = System.Drawing.Color.White;
            this.btnTKS.Image = global::DoAnPBL3.Properties.Resources.icons8_search_20px;
            this.btnTKS.Location = new System.Drawing.Point(293, 132);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(141, 32);
            this.btnTKS.TabIndex = 55;
            this.btnTKS.Text = "Tìm kiếm";
            this.btnTKS.Click += new System.EventHandler(this.BtnTKS_Click);
            // 
            // rjtbTKS
            // 
            this.rjtbTKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKS.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjtbTKS.BorderRadius = 15;
            this.rjtbTKS.BorderSize = 1;
            this.rjtbTKS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbTKS.ForeColor = System.Drawing.Color.Silver;
            this.rjtbTKS.Location = new System.Drawing.Point(6, 133);
            this.rjtbTKS.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKS.Multiline = false;
            this.rjtbTKS.Name = "rjtbTKS";
            this.rjtbTKS.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKS.PasswordChar = false;
            this.rjtbTKS.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKS.PlaceholderText = "Tìm kiếm theo ID, tên sách hoặc tên tác giả";
            this.rjtbTKS.Size = new System.Drawing.Size(280, 31);
            this.rjtbTKS.TabIndex = 37;
            this.rjtbTKS.Texts = "";
            this.rjtbTKS.UnderlinedStyle = false;
            this.rjtbTKS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjtbTKS_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.lblTotalVietnameseBook);
            this.panel2.Controls.Add(this.lblTotalBook);
            this.panel2.Controls.Add(this.totalBooks);
            this.panel2.Controls.Add(this.totalVietnameseBooks);
            this.panel2.Controls.Add(this.lblTotalEnglishBook);
            this.panel2.Controls.Add(this.totalEnglishBooks);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 95);
            this.panel2.TabIndex = 71;
            // 
            // ID_Book
            // 
            this.ID_Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Book.DataPropertyName = "ID_Book";
            this.ID_Book.FillWeight = 78.04252F;
            this.ID_Book.HeaderText = "ID";
            this.ID_Book.Name = "ID_Book";
            this.ID_Book.ReadOnly = true;
            // 
            // NameBook
            // 
            this.NameBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameBook.DataPropertyName = "NameBook";
            this.NameBook.FillWeight = 129.9492F;
            this.NameBook.HeaderText = "Tên sách";
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // PublishDate
            // 
            this.PublishDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PublishDate.DataPropertyName = "PublishDate";
            this.PublishDate.FillWeight = 98.66805F;
            this.PublishDate.HeaderText = "Ngày xuất bản";
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.ReadOnly = true;
            // 
            // NameAuthor
            // 
            this.NameAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameAuthor.DataPropertyName = "NameAuthor";
            this.NameAuthor.FillWeight = 98.66805F;
            this.NameAuthor.HeaderText = "Tác giả";
            this.NameAuthor.Name = "NameAuthor";
            this.NameAuthor.ReadOnly = true;
            // 
            // NameLanguage
            // 
            this.NameLanguage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameLanguage.DataPropertyName = "NameLanguage";
            this.NameLanguage.FillWeight = 98.66805F;
            this.NameLanguage.HeaderText = "Ngôn ngữ";
            this.NameLanguage.Name = "NameLanguage";
            this.NameLanguage.ReadOnly = true;
            // 
            // NameGenre
            // 
            this.NameGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameGenre.DataPropertyName = "NameGenre";
            this.NameGenre.FillWeight = 98.66805F;
            this.NameGenre.HeaderText = "Thể loại";
            this.NameGenre.Name = "NameGenre";
            this.NameGenre.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 98.66805F;
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 98.66805F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // FormQLBSNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNotificationCounter);
            this.Controls.Add(this.NotificationCircle);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dgvQLBSNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKS);
            this.Controls.Add(this.rjtbTKS);
            this.Controls.Add(this.xuiSegmentSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLBSNV";
            this.Text = "Bán sách";
            this.Load += new System.EventHandler(this.FormQLBSNV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUISegment xuiSegmentSach;
        private RJTextBox rjtbTKS;
        private RJButton rjbtnOrder;
        private Guna.UI2.WinForms.Guna2Button btnTKS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label totalEnglishBooks;
        private System.Windows.Forms.Label lblTotalEnglishBook;
        private System.Windows.Forms.Label totalVietnameseBooks;
        private System.Windows.Forms.Label lblTotalVietnameseBook;
        private System.Windows.Forms.Label totalBooks;
        private System.Windows.Forms.Label lblTotalBook;
        private RJButton rjbtnAddCart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLBSNV;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2CircleButton NotificationCircle;
        private System.Windows.Forms.Label lblNotificationCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}