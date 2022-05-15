
namespace DoAnPBL3
{
    partial class FormMenuNote
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
            this.Notes = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddNote = new DoAnPBL3.RJButton();
            this.SuspendLayout();
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(1, 119);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(978, 412);
            this.Notes.TabIndex = 0;
            this.Notes.Paint += new System.Windows.Forms.PaintEventHandler(this.Notes_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNote.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNote.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddNote.BorderRadius = 20;
            this.btnAddNote.BorderSize = 0;
            this.btnAddNote.FlatAppearance.BorderSize = 0;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.Image = global::DoAnPBL3.Properties.Resources.icons8_create_document_30px;
            this.btnAddNote.Location = new System.Drawing.Point(763, 61);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(150, 40);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Thêm ghi chú";
            this.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNote.TextColor = System.Drawing.Color.White;
            this.btnAddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // FormMenuNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.btnAddNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuNote";
            this.Text = "Ghi chú";
            this.Load += new System.EventHandler(this.FormMenuNote_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMenuNote_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Notes;
        private RJButton btnAddNote;
        private System.Windows.Forms.Timer timer1;
    }
}