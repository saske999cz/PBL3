
namespace DoAnPBL3
{
    partial class FormAdminSettingMenu
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
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnNote = new FontAwesome.Sharp.IconButton();
            this.btnSetupMode = new FontAwesome.Sharp.IconButton();
            this.btnEditAccount = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 20;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 156);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(178, 52);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNote
            // 
            this.btnNote.BackColor = System.Drawing.Color.SlateGray;
            this.btnNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNote.FlatAppearance.BorderSize = 0;
            this.btnNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNote.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnNote.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNote.IconSize = 20;
            this.btnNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNote.Location = new System.Drawing.Point(0, 104);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(178, 52);
            this.btnNote.TabIndex = 2;
            this.btnNote.Text = "Ghi chú";
            this.btnNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnSetupMode
            // 
            this.btnSetupMode.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSetupMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetupMode.FlatAppearance.BorderSize = 0;
            this.btnSetupMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetupMode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupMode.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.btnSetupMode.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetupMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetupMode.IconSize = 20;
            this.btnSetupMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetupMode.Location = new System.Drawing.Point(0, 52);
            this.btnSetupMode.Name = "btnSetupMode";
            this.btnSetupMode.Size = new System.Drawing.Size(178, 52);
            this.btnSetupMode.TabIndex = 1;
            this.btnSetupMode.Text = "Thay đổi Mode";
            this.btnSetupMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetupMode.UseVisualStyleBackColor = false;
            this.btnSetupMode.Click += new System.EventHandler(this.btnSetupMode_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditAccount.FlatAppearance.BorderSize = 0;
            this.btnEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditAccount.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEditAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditAccount.IconSize = 20;
            this.btnEditAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAccount.Location = new System.Drawing.Point(0, 0);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(178, 52);
            this.btnEditAccount.TabIndex = 0;
            this.btnEditAccount.Text = "Chỉnh sửa tài khoản";
            this.btnEditAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditAccount.UseVisualStyleBackColor = false;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // FormAdminSettingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(178, 212);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnSetupMode);
            this.Controls.Add(this.btnEditAccount);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminSettingMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Settings Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEditAccount;
        private FontAwesome.Sharp.IconButton btnSetupMode;
        private FontAwesome.Sharp.IconButton btnNote;
        private FontAwesome.Sharp.IconButton btnLogOut;
    }
}