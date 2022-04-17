
namespace DoAnPBL3
{
    partial class FormQLKHNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rjtbTKNV = new DoAnPBL3.RJTextBox();
            this.xuiSegmentNV = new XanderUI.XUISegment();
            this.dgvQLKHNV = new System.Windows.Forms.DataGridView();
            this.btnAddNV = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnTKNV = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKHNV)).BeginInit();
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
            this.rjtbTKNV.Location = new System.Drawing.Point(5, 133);
            this.rjtbTKNV.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKNV.Multiline = false;
            this.rjtbTKNV.Name = "rjtbTKNV";
            this.rjtbTKNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKNV.PasswordChar = false;
            this.rjtbTKNV.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKNV.PlaceholderText = "Tìm kiếm";
            this.rjtbTKNV.Size = new System.Drawing.Size(250, 31);
            this.rjtbTKNV.TabIndex = 52;
            this.rjtbTKNV.Texts = "";
            this.rjtbTKNV.UnderlinedStyle = false;
            // 
            // xuiSegmentNV
            // 
            this.xuiSegmentNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegmentNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSegmentNV.Items = "Tất cả, Tiếng Việt , Tiếng Anh";
            this.xuiSegmentNV.Location = new System.Drawing.Point(512, 130);
            this.xuiSegmentNV.Margin = new System.Windows.Forms.Padding(2);
            this.xuiSegmentNV.Name = "xuiSegmentNV";
            this.xuiSegmentNV.SegmentActiveTextColor = System.Drawing.SystemColors.Highlight;
            this.xuiSegmentNV.SegmentBackColor = System.Drawing.Color.CornflowerBlue;
            this.xuiSegmentNV.SegmentColor = System.Drawing.Color.Blue;
            this.xuiSegmentNV.SegmentInactiveTextColor = System.Drawing.Color.White;
            this.xuiSegmentNV.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuiSegmentNV.SelectedIndex = 0;
            this.xuiSegmentNV.Size = new System.Drawing.Size(314, 34);
            this.xuiSegmentNV.TabIndex = 50;
            // 
            // dgvQLKHNV
            // 
            this.dgvQLKHNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQLKHNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQLKHNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLKHNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLKHNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLKHNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLKHNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLKHNV.ColumnHeadersHeight = 20;
            this.dgvQLKHNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLKHNV.EnableHeadersVisualStyles = false;
            this.dgvQLKHNV.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvQLKHNV.Location = new System.Drawing.Point(5, 170);
            this.dgvQLKHNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLKHNV.Name = "dgvQLKHNV";
            this.dgvQLKHNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLKHNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQLKHNV.RowHeadersVisible = false;
            this.dgvQLKHNV.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvQLKHNV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQLKHNV.RowTemplate.Height = 24;
            this.dgvQLKHNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLKHNV.Size = new System.Drawing.Size(821, 413);
            this.dgvQLKHNV.TabIndex = 48;
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
            this.btnAddNV.Location = new System.Drawing.Point(833, 175);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(143, 44);
            this.btnAddNV.TabIndex = 53;
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
            this.iconPictureBox1.BackgroundImage = global::DoAnPBL3.Properties.Resources.teamwork1;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(437, 2);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(90, 72);
            this.iconPictureBox1.TabIndex = 51;
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
            this.btnTKNV.Location = new System.Drawing.Point(261, 131);
            this.btnTKNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(133, 34);
            this.btnTKNV.TabIndex = 49;
            this.btnTKNV.Text = "Tìm kiếm";
            this.btnTKNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTKNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTKNV.UseVisualStyleBackColor = false;
            // 
            // FormQLKHNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.btnAddNV);
            this.Controls.Add(this.rjtbTKNV);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.xuiSegmentNV);
            this.Controls.Add(this.btnTKNV);
            this.Controls.Add(this.dgvQLKHNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLKHNV";
            this.Text = "FormQLKHNV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKHNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAddNV;
        private RJTextBox rjtbTKNV;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private XanderUI.XUISegment xuiSegmentNV;
        private FontAwesome.Sharp.IconButton btnTKNV;
        private System.Windows.Forms.DataGridView dgvQLKHNV;
    }
}