
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLBSNV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiSegmentSach = new XanderUI.XUISegment();
            this.englishBook = new System.Windows.Forms.Label();
            this.lblEnglishBook = new System.Windows.Forms.Label();
            this.vietnameseBook = new System.Windows.Forms.Label();
            this.lblVietnameseBook = new System.Windows.Forms.Label();
            this.totalBook = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTKS = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjbtnBuy = new DoAnPBL3.RJButton();
            this.rjbtnAddCart = new DoAnPBL3.RJButton();
            this.dgvQLBSNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.rjtbTKS = new DoAnPBL3.RJTextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).BeginInit();
            this.panelHeader.SuspendLayout();
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
            // englishBook
            // 
            this.englishBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.englishBook.AutoSize = true;
            this.englishBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishBook.ForeColor = System.Drawing.Color.White;
            this.englishBook.Location = new System.Drawing.Point(806, 57);
            this.englishBook.Name = "englishBook";
            this.englishBook.Size = new System.Drawing.Size(29, 16);
            this.englishBook.TabIndex = 61;
            this.englishBook.Text = "100";
            // 
            // lblEnglishBook
            // 
            this.lblEnglishBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnglishBook.AutoSize = true;
            this.lblEnglishBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblEnglishBook.Location = new System.Drawing.Point(762, 26);
            this.lblEnglishBook.Name = "lblEnglishBook";
            this.lblEnglishBook.Size = new System.Drawing.Size(123, 16);
            this.lblEnglishBook.TabIndex = 60;
            this.lblEnglishBook.Text = "Số sách tiếng Anh";
            // 
            // vietnameseBook
            // 
            this.vietnameseBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vietnameseBook.AutoSize = true;
            this.vietnameseBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vietnameseBook.ForeColor = System.Drawing.Color.White;
            this.vietnameseBook.Location = new System.Drawing.Point(461, 57);
            this.vietnameseBook.Name = "vietnameseBook";
            this.vietnameseBook.Size = new System.Drawing.Size(29, 16);
            this.vietnameseBook.TabIndex = 59;
            this.vietnameseBook.Text = "100";
            // 
            // lblVietnameseBook
            // 
            this.lblVietnameseBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVietnameseBook.AutoSize = true;
            this.lblVietnameseBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVietnameseBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblVietnameseBook.Location = new System.Drawing.Point(418, 26);
            this.lblVietnameseBook.Name = "lblVietnameseBook";
            this.lblVietnameseBook.Size = new System.Drawing.Size(123, 16);
            this.lblVietnameseBook.TabIndex = 58;
            this.lblVietnameseBook.Text = "Số sách tiếng Việt";
            // 
            // totalBook
            // 
            this.totalBook.AutoSize = true;
            this.totalBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBook.ForeColor = System.Drawing.Color.White;
            this.totalBook.Location = new System.Drawing.Point(93, 57);
            this.totalBook.Name = "totalBook";
            this.totalBook.Size = new System.Drawing.Size(29, 16);
            this.totalBook.TabIndex = 57;
            this.totalBook.Text = "100";
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.AutoSize = true;
            this.lblTotalBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalBook.Location = new System.Drawing.Point(37, 26);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(155, 16);
            this.lblTotalBook.TabIndex = 56;
            this.lblTotalBook.Text = "Tổng số sách đang bán";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(198, 20);
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
            this.pictureBox1.Location = new System.Drawing.Point(883, 20);
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
            this.pictureBox2.Location = new System.Drawing.Point(539, 20);
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
            this.btnTKS.Location = new System.Drawing.Point(289, 133);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(141, 32);
            this.btnTKS.TabIndex = 55;
            this.btnTKS.Text = "Tìm kiếm";
            this.btnTKS.Click += new System.EventHandler(this.BtnTKS_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this.xuiSegmentSach;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rjbtnBuy);
            this.panel1.Controls.Add(this.rjbtnAddCart);
            this.panel1.Location = new System.Drawing.Point(828, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 93);
            this.panel1.TabIndex = 66;
            // 
            // rjbtnBuy
            // 
            this.rjbtnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjbtnBuy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.rjbtnBuy.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.rjbtnBuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnBuy.BorderRadius = 20;
            this.rjbtnBuy.BorderSize = 0;
            this.rjbtnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnBuy.FlatAppearance.BorderSize = 0;
            this.rjbtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnBuy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnBuy.ForeColor = System.Drawing.Color.White;
            this.rjbtnBuy.Image = global::DoAnPBL3.Properties.Resources.icons8_cheap_2_30px;
            this.rjbtnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjbtnBuy.Location = new System.Drawing.Point(0, 1);
            this.rjbtnBuy.Name = "rjbtnBuy";
            this.rjbtnBuy.Size = new System.Drawing.Size(150, 40);
            this.rjbtnBuy.TabIndex = 38;
            this.rjbtnBuy.Text = "Mua sách";
            this.rjbtnBuy.TextColor = System.Drawing.Color.White;
            this.rjbtnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnBuy.UseVisualStyleBackColor = false;
            this.rjbtnBuy.Click += new System.EventHandler(this.RjbtnBuy_Click);
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
            this.rjbtnAddCart.Location = new System.Drawing.Point(0, 49);
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
            // dgvQLBSNV
            // 
            this.dgvQLBSNV.AllowUserToAddRows = false;
            this.dgvQLBSNV.AllowUserToDeleteRows = false;
            this.dgvQLBSNV.AllowUserToResizeColumns = false;
            this.dgvQLBSNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLBSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLBSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLBSNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLBSNV.EnableHeadersVisualStyles = false;
            this.dgvQLBSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLBSNV.Location = new System.Drawing.Point(6, 169);
            this.dgvQLBSNV.Name = "dgvQLBSNV";
            this.dgvQLBSNV.ReadOnly = true;
            this.dgvQLBSNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBSNV.RowHeadersVisible = false;
            this.dgvQLBSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBSNV.Size = new System.Drawing.Size(819, 413);
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
            this.rjtbTKS.PlaceholderText = "Tìm kiếm theo ID, tên sách hoặc tên tác giả";
            this.rjtbTKS.Size = new System.Drawing.Size(276, 31);
            this.rjtbTKS.TabIndex = 37;
            this.rjtbTKS.Texts = "";
            this.rjtbTKS.UnderlinedStyle = false;
            this.rjtbTKS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjtbTKS_KeyPress);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.lblVietnameseBook);
            this.panelHeader.Controls.Add(this.lblTotalBook);
            this.panelHeader.Controls.Add(this.totalBook);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.vietnameseBook);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.lblEnglishBook);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.englishBook);
            this.panelHeader.Location = new System.Drawing.Point(12, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 68;
            // 
            // ID_Book
            // 
            this.ID_Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Book.DataPropertyName = "ID_Book";
            this.ID_Book.FillWeight = 62.64247F;
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
            this.PublishDate.FillWeight = 101.2347F;
            this.PublishDate.HeaderText = "Ngày xuất bản";
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.ReadOnly = true;
            // 
            // NameAuthor
            // 
            this.NameAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameAuthor.DataPropertyName = "NameAuthor";
            this.NameAuthor.FillWeight = 101.2347F;
            this.NameAuthor.HeaderText = "Tác giả";
            this.NameAuthor.Name = "NameAuthor";
            this.NameAuthor.ReadOnly = true;
            // 
            // NameLanguage
            // 
            this.NameLanguage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameLanguage.DataPropertyName = "NameLanguage";
            this.NameLanguage.FillWeight = 101.2347F;
            this.NameLanguage.HeaderText = "Ngôn ngữ";
            this.NameLanguage.Name = "NameLanguage";
            this.NameLanguage.ReadOnly = true;
            // 
            // NameGenre
            // 
            this.NameGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameGenre.DataPropertyName = "NameGenre";
            this.NameGenre.FillWeight = 101.2347F;
            this.NameGenre.HeaderText = "Thể loại";
            this.NameGenre.Name = "NameGenre";
            this.NameGenre.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 101.2347F;
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 101.2347F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // FormQLBSNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.panelHeader);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUISegment xuiSegmentSach;
        private RJTextBox rjtbTKS;
        private RJButton rjbtnBuy;
        private Guna.UI2.WinForms.Guna2Button btnTKS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label englishBook;
        private System.Windows.Forms.Label lblEnglishBook;
        private System.Windows.Forms.Label vietnameseBook;
        private System.Windows.Forms.Label lblVietnameseBook;
        private System.Windows.Forms.Label totalBook;
        private System.Windows.Forms.Label lblTotalBook;
        private RJButton rjbtnAddCart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLBSNV;
        private System.Windows.Forms.Panel panelHeader;
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