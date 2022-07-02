
namespace DoAnPBL3
{
    partial class FormMinNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMinNote));
            this.panelNote = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblNoteDate = new System.Windows.Forms.Label();
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.btnSaveNote = new FontAwesome.Sharp.IconButton();
            this.panelNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNote
            // 
            this.panelNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.panelNote.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.panelNote.BorderThickness = 1;
            this.panelNote.Controls.Add(this.btnSaveNote);
            this.panelNote.Controls.Add(this.btnDelete);
            this.panelNote.Controls.Add(this.guna2CircleButton1);
            this.panelNote.Controls.Add(this.lblNoteDate);
            this.panelNote.Controls.Add(this.lblNoteTitle);
            this.panelNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNote.Location = new System.Drawing.Point(0, 0);
            this.panelNote.Name = "panelNote";
            this.panelNote.Size = new System.Drawing.Size(978, 57);
            this.panelNote.TabIndex = 3;
            this.panelNote.Click += new System.EventHandler(this.PanelNote_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(898, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(39, 40);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(244, 73);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(107, 88);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            // 
            // lblNoteDate
            // 
            this.lblNoteDate.AutoSize = true;
            this.lblNoteDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteDate.ForeColor = System.Drawing.Color.White;
            this.lblNoteDate.Location = new System.Drawing.Point(13, 6);
            this.lblNoteDate.Name = "lblNoteDate";
            this.lblNoteDate.Size = new System.Drawing.Size(35, 14);
            this.lblNoteDate.TabIndex = 1;
            this.lblNoteDate.Text = "label1";
            // 
            // lblNoteTitle
            // 
            this.lblNoteTitle.AutoSize = true;
            this.lblNoteTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteTitle.ForeColor = System.Drawing.Color.White;
            this.lblNoteTitle.Location = new System.Drawing.Point(11, 28);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Size = new System.Drawing.Size(54, 19);
            this.lblNoteTitle.TabIndex = 0;
            this.lblNoteTitle.Text = "label1";
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNote.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnSaveNote.FlatAppearance.BorderSize = 0;
            this.btnSaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNote.ForeColor = System.Drawing.Color.White;
            this.btnSaveNote.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnSaveNote.IconColor = System.Drawing.Color.White;
            this.btnSaveNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveNote.IconSize = 30;
            this.btnSaveNote.Location = new System.Drawing.Point(765, 6);
            this.btnSaveNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(122, 44);
            this.btnSaveNote.TabIndex = 30;
            this.btnSaveNote.Text = "Lưu ghi chú";
            this.btnSaveNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveNote.UseVisualStyleBackColor = false;
            this.btnSaveNote.Click += new System.EventHandler(this.BtnSaveNote_Click);
            // 
            // FormMinNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(978, 57);
            this.Controls.Add(this.panelNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMinNote";
            this.Text = "FormMinNote";
            this.panelNote.ResumeLayout(false);
            this.panelNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelNote;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label lblNoteDate;
        private System.Windows.Forms.Label lblNoteTitle;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private FontAwesome.Sharp.IconButton btnSaveNote;
    }
}