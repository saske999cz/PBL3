
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiSegmentNV = new XanderUI.XUISegment();
            this.dgvQLBSNV = new System.Windows.Forms.DataGridView();
            this.rjtbTKNV = new DoAnPBL3.RJTextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnTKNV = new FontAwesome.Sharp.IconButton();
            this.rjbtnBuy = new DoAnPBL3.RJButton();
            this.rjbtnOrder = new DoAnPBL3.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiSegmentNV
            // 
            this.xuiSegmentNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegmentNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSegmentNV.Items = "Tất cả, Tiếng Việt , Tiếng Anh";
            this.xuiSegmentNV.Location = new System.Drawing.Point(513, 130);
            this.xuiSegmentNV.Margin = new System.Windows.Forms.Padding(2);
            this.xuiSegmentNV.Name = "xuiSegmentNV";
            this.xuiSegmentNV.SegmentActiveTextColor = System.Drawing.SystemColors.Highlight;
            this.xuiSegmentNV.SegmentBackColor = System.Drawing.Color.CornflowerBlue;
            this.xuiSegmentNV.SegmentColor = System.Drawing.Color.Blue;
            this.xuiSegmentNV.SegmentInactiveTextColor = System.Drawing.Color.White;
            this.xuiSegmentNV.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuiSegmentNV.SelectedIndex = 0;
            this.xuiSegmentNV.Size = new System.Drawing.Size(314, 34);
            this.xuiSegmentNV.TabIndex = 35;
            // 
            // dgvQLBSNV
            // 
            this.dgvQLBSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQLBSNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQLBSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLBSNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLBSNV.ColumnHeadersHeight = 20;
            this.dgvQLBSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBSNV.EnableHeadersVisualStyles = false;
            this.dgvQLBSNV.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvQLBSNV.Location = new System.Drawing.Point(6, 170);
            this.dgvQLBSNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLBSNV.Name = "dgvQLBSNV";
            this.dgvQLBSNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLBSNV.RowHeadersVisible = false;
            this.dgvQLBSNV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvQLBSNV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLBSNV.RowTemplate.Height = 24;
            this.dgvQLBSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBSNV.Size = new System.Drawing.Size(821, 413);
            this.dgvQLBSNV.TabIndex = 33;
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
            this.rjtbTKNV.Location = new System.Drawing.Point(6, 133);
            this.rjtbTKNV.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKNV.Multiline = false;
            this.rjtbTKNV.Name = "rjtbTKNV";
            this.rjtbTKNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKNV.PasswordChar = false;
            this.rjtbTKNV.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKNV.PlaceholderText = "Tìm kiếm";
            this.rjtbTKNV.Size = new System.Drawing.Size(250, 31);
            this.rjtbTKNV.TabIndex = 37;
            this.rjtbTKNV.Texts = "";
            this.rjtbTKNV.UnderlinedStyle = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.iconPictureBox1.BackgroundImage = global::DoAnPBL3.Properties.Resources.shopping_bags;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(438, 2);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(90, 72);
            this.iconPictureBox1.TabIndex = 36;
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
            this.btnTKNV.Location = new System.Drawing.Point(262, 131);
            this.btnTKNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(133, 34);
            this.btnTKNV.TabIndex = 34;
            this.btnTKNV.Text = "Tìm kiếm";
            this.btnTKNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTKNV.UseVisualStyleBackColor = false;
            // 
            // rjbtnBuy
            // 
            this.rjbtnBuy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.rjbtnBuy.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.rjbtnBuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnBuy.BorderRadius = 20;
            this.rjbtnBuy.BorderSize = 0;
            this.rjbtnBuy.FlatAppearance.BorderSize = 0;
            this.rjbtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnBuy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnBuy.ForeColor = System.Drawing.Color.White;
            this.rjbtnBuy.Location = new System.Drawing.Point(829, 170);
            this.rjbtnBuy.Name = "rjbtnBuy";
            this.rjbtnBuy.Size = new System.Drawing.Size(150, 40);
            this.rjbtnBuy.TabIndex = 38;
            this.rjbtnBuy.Text = "Mua sách";
            this.rjbtnBuy.TextColor = System.Drawing.Color.White;
            this.rjbtnBuy.UseVisualStyleBackColor = false;
            // 
            // rjbtnOrder
            // 
            this.rjbtnOrder.BackColor = System.Drawing.Color.Goldenrod;
            this.rjbtnOrder.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.rjbtnOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnOrder.BorderRadius = 20;
            this.rjbtnOrder.BorderSize = 0;
            this.rjbtnOrder.FlatAppearance.BorderSize = 0;
            this.rjbtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnOrder.ForeColor = System.Drawing.Color.White;
            this.rjbtnOrder.Location = new System.Drawing.Point(829, 227);
            this.rjbtnOrder.Name = "rjbtnOrder";
            this.rjbtnOrder.Size = new System.Drawing.Size(150, 40);
            this.rjbtnOrder.TabIndex = 39;
            this.rjbtnOrder.Text = "Đặt hàng";
            this.rjbtnOrder.TextColor = System.Drawing.Color.White;
            this.rjbtnOrder.UseVisualStyleBackColor = false;
            // 
            // FormQLBSNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.rjbtnOrder);
            this.Controls.Add(this.rjbtnBuy);
            this.Controls.Add(this.rjtbTKNV);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.xuiSegmentNV);
            this.Controls.Add(this.btnTKNV);
            this.Controls.Add(this.dgvQLBSNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLBSNV";
            this.Text = "Bán sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private XanderUI.XUISegment xuiSegmentNV;
        private FontAwesome.Sharp.IconButton btnTKNV;
        private System.Windows.Forms.DataGridView dgvQLBSNV;
        private RJTextBox rjtbTKNV;
        private RJButton rjbtnBuy;
        private RJButton rjbtnOrder;
    }
}