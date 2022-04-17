
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rjtbTKNV = new DoAnPBL3.RJTextBox();
            this.xuiSegmentNV = new XanderUI.XUISegment();
            this.dgvQLSNV = new System.Windows.Forms.DataGridView();
            this.btnSuaNV = new FontAwesome.Sharp.IconButton();
            this.btnDeleteNV = new FontAwesome.Sharp.IconButton();
            this.btnAddNV = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnTKNV = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rjtbTKNV
            // 
            this.rjtbTKNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKNV.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjtbTKNV.BorderRadius = 15;
            this.rjtbTKNV.BorderSize = 1;
            this.rjtbTKNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbTKNV.ForeColor = System.Drawing.Color.Silver;
            this.rjtbTKNV.Location = new System.Drawing.Point(4, 133);
            this.rjtbTKNV.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKNV.Multiline = false;
            this.rjtbTKNV.Name = "rjtbTKNV";
            this.rjtbTKNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKNV.PasswordChar = false;
            this.rjtbTKNV.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKNV.PlaceholderText = "Tìm kiếm";
            this.rjtbTKNV.Size = new System.Drawing.Size(250, 31);
            this.rjtbTKNV.TabIndex = 44;
            this.rjtbTKNV.Texts = "";
            this.rjtbTKNV.UnderlinedStyle = false;
            // 
            // xuiSegmentNV
            // 
            this.xuiSegmentNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegmentNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSegmentNV.Items = "Tất cả, Tiếng Việt , Tiếng Anh";
            this.xuiSegmentNV.Location = new System.Drawing.Point(511, 130);
            this.xuiSegmentNV.Margin = new System.Windows.Forms.Padding(2);
            this.xuiSegmentNV.Name = "xuiSegmentNV";
            this.xuiSegmentNV.SegmentActiveTextColor = System.Drawing.SystemColors.Highlight;
            this.xuiSegmentNV.SegmentBackColor = System.Drawing.Color.CornflowerBlue;
            this.xuiSegmentNV.SegmentColor = System.Drawing.Color.Blue;
            this.xuiSegmentNV.SegmentInactiveTextColor = System.Drawing.Color.White;
            this.xuiSegmentNV.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuiSegmentNV.SelectedIndex = 0;
            this.xuiSegmentNV.Size = new System.Drawing.Size(314, 34);
            this.xuiSegmentNV.TabIndex = 42;
            // 
            // dgvQLSNV
            // 
            this.dgvQLSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQLSNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQLSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLSNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLSNV.ColumnHeadersHeight = 20;
            this.dgvQLSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLSNV.EnableHeadersVisualStyles = false;
            this.dgvQLSNV.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvQLSNV.Location = new System.Drawing.Point(4, 170);
            this.dgvQLSNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLSNV.Name = "dgvQLSNV";
            this.dgvQLSNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLSNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLSNV.RowHeadersVisible = false;
            this.dgvQLSNV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvQLSNV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLSNV.RowTemplate.Height = 24;
            this.dgvQLSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLSNV.Size = new System.Drawing.Size(821, 413);
            this.dgvQLSNV.TabIndex = 40;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSuaNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnSuaNV.FlatAppearance.BorderSize = 0;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnSuaNV.IconColor = System.Drawing.Color.White;
            this.btnSuaNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaNV.IconSize = 30;
            this.btnSuaNV.Location = new System.Drawing.Point(832, 230);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(143, 44);
            this.btnSuaNV.TabIndex = 47;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNV.UseVisualStyleBackColor = false;
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteNV.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnDeleteNV.FlatAppearance.BorderSize = 0;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNV.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNV.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnDeleteNV.IconColor = System.Drawing.Color.White;
            this.btnDeleteNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteNV.IconSize = 30;
            this.btnDeleteNV.Location = new System.Drawing.Point(832, 283);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(143, 44);
            this.btnDeleteNV.TabIndex = 46;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            // 
            // btnAddNV
            // 
            this.btnAddNV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNV.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAddNV.FlatAppearance.BorderSize = 0;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.ForeColor = System.Drawing.Color.White;
            this.btnAddNV.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddNV.IconColor = System.Drawing.Color.White;
            this.btnAddNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNV.IconSize = 30;
            this.btnAddNV.Location = new System.Drawing.Point(832, 175);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(143, 44);
            this.btnAddNV.TabIndex = 45;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.iconPictureBox1.BackgroundImage = global::DoAnPBL3.Properties.Resources.fairy_tale;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(436, 2);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(90, 72);
            this.iconPictureBox1.TabIndex = 43;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnTKNV
            // 
            this.btnTKNV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTKNV.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTKNV.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTKNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKNV.ForeColor = System.Drawing.Color.White;
            this.btnTKNV.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTKNV.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTKNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTKNV.IconSize = 30;
            this.btnTKNV.Location = new System.Drawing.Point(260, 131);
            this.btnTKNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(133, 34);
            this.btnTKNV.TabIndex = 41;
            this.btnTKNV.Text = "Tìm kiếm";
            this.btnTKNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTKNV.UseVisualStyleBackColor = false;
            // 
            // FormQLS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnAddNV);
            this.Controls.Add(this.rjtbTKNV);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.xuiSegmentNV);
            this.Controls.Add(this.btnTKNV);
            this.Controls.Add(this.dgvQLSNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLS";
            this.Text = "Quản lý sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJTextBox rjtbTKNV;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private XanderUI.XUISegment xuiSegmentNV;
        private FontAwesome.Sharp.IconButton btnTKNV;
        private System.Windows.Forms.DataGridView dgvQLSNV;
        private FontAwesome.Sharp.IconButton btnSuaNV;
        private FontAwesome.Sharp.IconButton btnDeleteNV;
        private FontAwesome.Sharp.IconButton btnAddNV;
    }
}