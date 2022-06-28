
namespace DoAnPBL3
{
    partial class FormQLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSuaSach = new FontAwesome.Sharp.IconButton();
            this.btnDeleteSach = new FontAwesome.Sharp.IconButton();
            this.btnAddSach = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjtbTKS = new DoAnPBL3.RJTextBox();
            this.dgvQLSNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSNV)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiSegmentSach
            // 
            this.xuiSegmentSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiSegmentSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegmentSach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSegmentSach.Items = "Tất cả, Tiếng Việt , Tiếng Anh";
            this.xuiSegmentSach.Location = new System.Drawing.Point(511, 130);
            this.xuiSegmentSach.Margin = new System.Windows.Forms.Padding(2);
            this.xuiSegmentSach.Name = "xuiSegmentSach";
            this.xuiSegmentSach.SegmentActiveTextColor = System.Drawing.SystemColors.Highlight;
            this.xuiSegmentSach.SegmentBackColor = System.Drawing.Color.CornflowerBlue;
            this.xuiSegmentSach.SegmentColor = System.Drawing.Color.Blue;
            this.xuiSegmentSach.SegmentInactiveTextColor = System.Drawing.Color.White;
            this.xuiSegmentSach.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuiSegmentSach.SelectedIndex = 0;
            this.xuiSegmentSach.Size = new System.Drawing.Size(314, 34);
            this.xuiSegmentSach.TabIndex = 42;
            this.xuiSegmentSach.Click += new System.EventHandler(this.XuiSegmentSach_Click);
            // 
            // englishBook
            // 
            this.englishBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.englishBook.AutoSize = true;
            this.englishBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishBook.ForeColor = System.Drawing.Color.White;
            this.englishBook.Location = new System.Drawing.Point(807, 57);
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
            this.lblEnglishBook.Location = new System.Drawing.Point(763, 26);
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
            this.vietnameseBook.Location = new System.Drawing.Point(449, 57);
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
            this.lblVietnameseBook.Location = new System.Drawing.Point(406, 26);
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
            this.totalBook.Location = new System.Drawing.Point(91, 57);
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
            this.lblTotalBook.Location = new System.Drawing.Point(35, 26);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(155, 16);
            this.lblTotalBook.TabIndex = 56;
            this.lblTotalBook.Text = "Tổng số sách đang bán";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(196, 20);
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
            this.pictureBox1.Location = new System.Drawing.Point(892, 20);
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
            this.pictureBox2.Location = new System.Drawing.Point(527, 20);
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
            this.btnTKS.Location = new System.Drawing.Point(288, 133);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(141, 32);
            this.btnTKS.TabIndex = 55;
            this.btnTKS.Text = "Tìm kiếm";
            this.btnTKS.Click += new System.EventHandler(this.BtnTKS_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaSach.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnSuaSach.FlatAppearance.BorderSize = 0;
            this.btnSuaSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSach.ForeColor = System.Drawing.Color.White;
            this.btnSuaSach.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnSuaSach.IconColor = System.Drawing.Color.White;
            this.btnSuaSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaSach.IconSize = 30;
            this.btnSuaSach.Location = new System.Drawing.Point(7, 50);
            this.btnSuaSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(143, 44);
            this.btnSuaSach.TabIndex = 47;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaSach.UseVisualStyleBackColor = false;
            this.btnSuaSach.Click += new System.EventHandler(this.BtnSuaSach_Click);
            // 
            // btnDeleteSach
            // 
            this.btnDeleteSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteSach.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnDeleteSach.FlatAppearance.BorderSize = 0;
            this.btnDeleteSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSach.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSach.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.btnDeleteSach.IconColor = System.Drawing.Color.White;
            this.btnDeleteSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteSach.IconSize = 30;
            this.btnDeleteSach.Location = new System.Drawing.Point(7, 99);
            this.btnDeleteSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSach.Name = "btnDeleteSach";
            this.btnDeleteSach.Size = new System.Drawing.Size(143, 44);
            this.btnDeleteSach.TabIndex = 46;
            this.btnDeleteSach.Text = "Xóa";
            this.btnDeleteSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSach.UseVisualStyleBackColor = false;
            this.btnDeleteSach.Click += new System.EventHandler(this.BtnDeleteSach_Click);
            // 
            // btnAddSach
            // 
            this.btnAddSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSach.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAddSach.FlatAppearance.BorderSize = 0;
            this.btnAddSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSach.ForeColor = System.Drawing.Color.White;
            this.btnAddSach.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnAddSach.IconColor = System.Drawing.Color.White;
            this.btnAddSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSach.IconSize = 30;
            this.btnAddSach.Location = new System.Drawing.Point(6, 2);
            this.btnAddSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSach.Name = "btnAddSach";
            this.btnAddSach.Size = new System.Drawing.Size(143, 44);
            this.btnAddSach.TabIndex = 45;
            this.btnAddSach.Text = "Thêm";
            this.btnAddSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSach.UseVisualStyleBackColor = false;
            this.btnAddSach.Click += new System.EventHandler(this.BtnAddSach_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this.xuiSegmentSach;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 5;
            this.guna2Elipse2.TargetControl = this.btnAddSach;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 5;
            this.guna2Elipse3.TargetControl = this.btnSuaSach;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 5;
            this.guna2Elipse4.TargetControl = this.btnDeleteSach;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAddSach);
            this.panel1.Controls.Add(this.btnSuaSach);
            this.panel1.Controls.Add(this.btnDeleteSach);
            this.panel1.Location = new System.Drawing.Point(827, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 154);
            this.panel1.TabIndex = 65;
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
            this.rjtbTKS.Location = new System.Drawing.Point(4, 133);
            this.rjtbTKS.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKS.Multiline = false;
            this.rjtbTKS.Name = "rjtbTKS";
            this.rjtbTKS.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKS.PasswordChar = false;
            this.rjtbTKS.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKS.PlaceholderText = "Tìm kiếm theo ID, tên sách hoặc tên tác giả";
            this.rjtbTKS.Size = new System.Drawing.Size(277, 31);
            this.rjtbTKS.TabIndex = 44;
            this.rjtbTKS.Texts = "";
            this.rjtbTKS.UnderlinedStyle = false;
            this.rjtbTKS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjtbTKS_KeyPress);
            // 
            // dgvQLSNV
            // 
            this.dgvQLSNV.AllowUserToAddRows = false;
            this.dgvQLSNV.AllowUserToDeleteRows = false;
            this.dgvQLSNV.AllowUserToResizeColumns = false;
            this.dgvQLSNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvQLSNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvQLSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLSNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvQLSNV.ColumnHeadersHeight = 30;
            this.dgvQLSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Book,
            this.NameBook,
            this.PublishDate,
            this.NameAuthor,
            this.NameLanguage,
            this.NameGenre,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLSNV.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvQLSNV.EnableHeadersVisualStyles = false;
            this.dgvQLSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLSNV.Location = new System.Drawing.Point(12, 173);
            this.dgvQLSNV.Name = "dgvQLSNV";
            this.dgvQLSNV.ReadOnly = true;
            this.dgvQLSNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLSNV.RowHeadersVisible = false;
            this.dgvQLSNV.RowHeadersWidth = 60;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLSNV.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvQLSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLSNV.Size = new System.Drawing.Size(816, 413);
            this.dgvQLSNV.TabIndex = 66;
            this.dgvQLSNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLSNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLSNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLSNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLSNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLSNV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLSNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLSNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLSNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLSNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLSNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLSNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLSNV.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLSNV.ThemeStyle.ReadOnly = true;
            this.dgvQLSNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLSNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLSNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLSNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvQLSNV.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLSNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLSNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLSNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLSNV_RowHeaderMouseClick);
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
            this.NameBook.FillWeight = 129.9493F;
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
            this.Price.HeaderText = "Giá tiền";
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
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.lblEnglishBook);
            this.panelHeader.Controls.Add(this.lblTotalBook);
            this.panelHeader.Controls.Add(this.totalBook);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.lblVietnameseBook);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.vietnameseBook);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.englishBook);
            this.panelHeader.Location = new System.Drawing.Point(12, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 67;
            // 
            // FormQLS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvQLSNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKS);
            this.Controls.Add(this.rjtbTKS);
            this.Controls.Add(this.xuiSegmentSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLS";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.FormQLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSNV)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RJTextBox rjtbTKS;
        private XanderUI.XUISegment xuiSegmentSach;
        private FontAwesome.Sharp.IconButton btnSuaSach;
        private FontAwesome.Sharp.IconButton btnDeleteSach;
        private FontAwesome.Sharp.IconButton btnAddSach;
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
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLSNV;
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