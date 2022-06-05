
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLS));
            this.xuiSegmentSach = new XanderUI.XUISegment();
            this.dgvQLSNV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSSTA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSSTV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTSSDB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblPageNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.xuiSegmentSach.Click += new System.EventHandler(this.xuiSegmentSach_Click);
            // 
            // dgvQLSNV
            // 
            this.dgvQLSNV.AllowUserToAddRows = false;
            this.dgvQLSNV.AllowUserToDeleteRows = false;
            this.dgvQLSNV.AllowUserToResizeColumns = false;
            this.dgvQLSNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLSNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvQLSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvQLSNV.ColumnHeadersHeight = 30;
            this.dgvQLSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameBook,
            this.Language,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLSNV.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvQLSNV.EnableHeadersVisualStyles = false;
            this.dgvQLSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLSNV.Location = new System.Drawing.Point(4, 170);
            this.dgvQLSNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLSNV.Name = "dgvQLSNV";
            this.dgvQLSNV.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLSNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvQLSNV.RowHeadersWidth = 51;
            this.dgvQLSNV.RowTemplate.Height = 24;
            this.dgvQLSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLSNV.Size = new System.Drawing.Size(821, 368);
            this.dgvQLSNV.TabIndex = 40;
            this.dgvQLSNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQLSNV_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID_Book";
            this.ID.FillWeight = 50.76143F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameBook
            // 
            this.NameBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameBook.DataPropertyName = "NameBook";
            this.NameBook.FillWeight = 155.2978F;
            this.NameBook.HeaderText = "Tên sách";
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // Language
            // 
            this.Language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Language.DataPropertyName = "NameLanguage";
            this.Language.FillWeight = 85.87595F;
            this.Language.HeaderText = "Ngôn ngữ";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 90.46779F;
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 117.5971F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // lblSSTA
            // 
            this.lblSSTA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSSTA.AutoSize = true;
            this.lblSSTA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSTA.ForeColor = System.Drawing.Color.White;
            this.lblSSTA.Location = new System.Drawing.Point(817, 49);
            this.lblSSTA.Name = "lblSSTA";
            this.lblSSTA.Size = new System.Drawing.Size(29, 16);
            this.lblSSTA.TabIndex = 61;
            this.lblSSTA.Text = "100";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(773, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Số sách tiếng Anh";
            // 
            // lblSSTV
            // 
            this.lblSSTV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSSTV.AutoSize = true;
            this.lblSSTV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSTV.ForeColor = System.Drawing.Color.White;
            this.lblSSTV.Location = new System.Drawing.Point(459, 49);
            this.lblSSTV.Name = "lblSSTV";
            this.lblSSTV.Size = new System.Drawing.Size(29, 16);
            this.lblSSTV.TabIndex = 59;
            this.lblSSTV.Text = "100";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(416, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Số sách tiếng Việt";
            // 
            // lblTSSDB
            // 
            this.lblTSSDB.AutoSize = true;
            this.lblTSSDB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSSDB.ForeColor = System.Drawing.Color.White;
            this.lblTSSDB.Location = new System.Drawing.Point(101, 49);
            this.lblTSSDB.Name = "lblTSSDB";
            this.lblTSSDB.Size = new System.Drawing.Size(29, 16);
            this.lblTSSDB.TabIndex = 57;
            this.lblTSSDB.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(45, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tổng số sách đang bán";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(206, 12);
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
            this.pictureBox1.Location = new System.Drawing.Point(894, 12);
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
            this.pictureBox2.Location = new System.Drawing.Point(537, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // btnTKS
            // 
            this.btnTKS.BorderRadius = 15;
            this.btnTKS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKS.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTKS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTKS.ForeColor = System.Drawing.Color.White;
            this.btnTKS.Image = global::DoAnPBL3.Properties.Resources.icons8_search_20px;
            this.btnTKS.Location = new System.Drawing.Point(261, 132);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(141, 32);
            this.btnTKS.TabIndex = 55;
            this.btnTKS.Text = "Tìm kiếm";
            this.btnTKS.Click += new System.EventHandler(this.btnTKS_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaSach.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnDeleteSach
            // 
            this.btnDeleteSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteSach.BackColor = System.Drawing.Color.Firebrick;
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
            this.btnDeleteSach.Click += new System.EventHandler(this.btnDeleteSach_Click);
            // 
            // btnAddSach
            // 
            this.btnAddSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSach.BackColor = System.Drawing.Color.MediumSeaGreen;
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
            this.btnAddSach.Click += new System.EventHandler(this.btnAddSach_Click);
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
            this.panel1.Location = new System.Drawing.Point(825, 170);
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
            this.rjtbTKS.PlaceholderText = "Tìm kiếm theo ID hoặc tên sách";
            this.rjtbTKS.Size = new System.Drawing.Size(250, 31);
            this.rjtbTKS.TabIndex = 44;
            this.rjtbTKS.Texts = "";
            this.rjtbTKS.UnderlinedStyle = false;
            this.rjtbTKS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtbTKS_KeyPress);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.BorderRadius = 2;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(263, 547);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(80, 29);
            this.btnPrevious.TabIndex = 66;
            this.btnPrevious.Text = "< Trước";
            this.btnPrevious.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BorderRadius = 2;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(459, 547);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 29);
            this.btnNext.TabIndex = 67;
            this.btnNext.Text = "Sau >";
            this.btnNext.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageNumber.ForeColor = System.Drawing.Color.White;
            this.lblPageNumber.Location = new System.Drawing.Point(362, 553);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(50, 18);
            this.lblPageNumber.TabIndex = 68;
            this.lblPageNumber.Text = "label1";
            // 
            // FormQLS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSSTA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSSTV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTSSDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTKS);
            this.Controls.Add(this.rjtbTKS);
            this.Controls.Add(this.xuiSegmentSach);
            this.Controls.Add(this.dgvQLSNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLS";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.FormQLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJTextBox rjtbTKS;
        private XanderUI.XUISegment xuiSegmentSach;
        private System.Windows.Forms.DataGridView dgvQLSNV;
        private FontAwesome.Sharp.IconButton btnSuaSach;
        private FontAwesome.Sharp.IconButton btnDeleteSach;
        private FontAwesome.Sharp.IconButton btnAddSach;
        private Guna.UI2.WinForms.Guna2Button btnTKS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSSTA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSSTV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTSSDB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label lblPageNumber;
    }
}