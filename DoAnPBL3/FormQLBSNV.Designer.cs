
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLBSNV));
            this.xuiSegmentSach = new XanderUI.XUISegment();
            this.dgvQLBSNV = new System.Windows.Forms.DataGridView();
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjbtnBuy = new DoAnPBL3.RJButton();
            this.rjbtnAddCart = new DoAnPBL3.RJButton();
            this.rjbtnOrder = new DoAnPBL3.RJButton();
            this.rjtbTKS = new DoAnPBL3.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).BeginInit();
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
            this.xuiSegmentSach.Click += new System.EventHandler(this.xuiSegmentSach_Click);
            // 
            // dgvQLBSNV
            // 
            this.dgvQLBSNV.AllowUserToAddRows = false;
            this.dgvQLBSNV.AllowUserToDeleteRows = false;
            this.dgvQLBSNV.AllowUserToResizeColumns = false;
            this.dgvQLBSNV.AllowUserToResizeRows = false;
            this.dgvQLBSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLBSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLBSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLBSNV.ColumnHeadersHeight = 30;
            this.dgvQLBSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameBook,
            this.NameLanguage,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLBSNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLBSNV.EnableHeadersVisualStyles = false;
            this.dgvQLBSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLBSNV.Location = new System.Drawing.Point(4, 170);
            this.dgvQLBSNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLBSNV.Name = "dgvQLBSNV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLBSNV.RowHeadersWidth = 51;
            this.dgvQLBSNV.RowTemplate.Height = 24;
            this.dgvQLBSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBSNV.Size = new System.Drawing.Size(821, 413);
            this.dgvQLBSNV.TabIndex = 33;
            this.dgvQLBSNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQLBSNV_RowHeaderMouseClick);
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
            this.btnTKS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKS.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTKS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTKS.ForeColor = System.Drawing.Color.White;
            this.btnTKS.Image = global::DoAnPBL3.Properties.Resources.icons8_search_20px;
            this.btnTKS.Location = new System.Drawing.Point(263, 133);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(141, 32);
            this.btnTKS.TabIndex = 55;
            this.btnTKS.Text = "Tìm kiếm";
            this.btnTKS.Click += new System.EventHandler(this.btnTKS_Click);
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
            this.panel1.Controls.Add(this.rjbtnOrder);
            this.panel1.Location = new System.Drawing.Point(830, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 155);
            this.panel1.TabIndex = 66;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID_Book";
            this.ID.FillWeight = 48.4852F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameBook
            // 
            this.NameBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameBook.DataPropertyName = "NameBook";
            this.NameBook.FillWeight = 153.6631F;
            this.NameBook.HeaderText = "Tên sách";
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // NameLanguage
            // 
            this.NameLanguage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameLanguage.DataPropertyName = "NameLanguage";
            this.NameLanguage.FillWeight = 83.06437F;
            this.NameLanguage.HeaderText = "Ngôn ngữ";
            this.NameLanguage.Name = "NameLanguage";
            this.NameLanguage.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 116.7513F;
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 98.036F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
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
            this.rjbtnBuy.Location = new System.Drawing.Point(0, 3);
            this.rjbtnBuy.Name = "rjbtnBuy";
            this.rjbtnBuy.Size = new System.Drawing.Size(150, 40);
            this.rjbtnBuy.TabIndex = 38;
            this.rjbtnBuy.Text = "Mua sách";
            this.rjbtnBuy.TextColor = System.Drawing.Color.White;
            this.rjbtnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnBuy.UseVisualStyleBackColor = false;
            this.rjbtnBuy.Click += new System.EventHandler(this.rjbtnBuy_Click);
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
            this.rjbtnAddCart.Location = new System.Drawing.Point(0, 112);
            this.rjbtnAddCart.Name = "rjbtnAddCart";
            this.rjbtnAddCart.Padding = new System.Windows.Forms.Padding(18, 0, 16, 0);
            this.rjbtnAddCart.Size = new System.Drawing.Size(150, 40);
            this.rjbtnAddCart.TabIndex = 65;
            this.rjbtnAddCart.Text = "Thêm vào giỏ hàng";
            this.rjbtnAddCart.TextColor = System.Drawing.Color.White;
            this.rjbtnAddCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnAddCart.UseVisualStyleBackColor = false;
            this.rjbtnAddCart.Click += new System.EventHandler(this.rjbtnAddCart_Click);
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
            this.rjbtnOrder.Image = global::DoAnPBL3.Properties.Resources.icons8_drop_shipping_30px;
            this.rjbtnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjbtnOrder.Location = new System.Drawing.Point(0, 58);
            this.rjbtnOrder.Name = "rjbtnOrder";
            this.rjbtnOrder.Size = new System.Drawing.Size(150, 40);
            this.rjbtnOrder.TabIndex = 39;
            this.rjbtnOrder.Text = "Đặt hàng";
            this.rjbtnOrder.TextColor = System.Drawing.Color.White;
            this.rjbtnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnOrder.UseVisualStyleBackColor = false;
            this.rjbtnOrder.Click += new System.EventHandler(this.rjbtnOrder_Click);
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
            this.rjtbTKS.PlaceholderText = "Tìm kiếm theo ID sách hoặc tên sách";
            this.rjtbTKS.Size = new System.Drawing.Size(250, 31);
            this.rjtbTKS.TabIndex = 37;
            this.rjtbTKS.Texts = "";
            this.rjtbTKS.UnderlinedStyle = false;
            this.rjtbTKS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtbTKS_KeyPress);
            // 
            // FormQLBSNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
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
            this.Controls.Add(this.dgvQLBSNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLBSNV";
            this.Text = "Bán sách";
            this.Load += new System.EventHandler(this.FormQLBSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUISegment xuiSegmentSach;
        private System.Windows.Forms.DataGridView dgvQLBSNV;
        private RJTextBox rjtbTKS;
        private RJButton rjbtnBuy;
        private RJButton rjbtnOrder;
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
        private RJButton rjbtnAddCart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}