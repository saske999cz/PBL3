
namespace DoAnPBL3
{
    partial class FormCart
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
            Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumDiverse = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjbtnCancel = new DoAnPBL3.RJButton();
            this.rjbtnBuy = new DoAnPBL3.RJButton();
            this.btnOK = new DoAnPBL3.RJButton();
            this.tbNumber = new DoAnPBL3.RJTextBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 10;
            guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            guna2ShadowForm1.TargetForm = this;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1115, 41);
            this.panelTitleBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.shopping_cart;
            this.pictureBox1.Location = new System.Drawing.Point(97, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giỏ hàng";
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 10;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thêm số loại sách muốn mua";
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Location = new System.Drawing.Point(0, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1115, 245);
            this.panelDesktop.TabIndex = 5;
            this.panelDesktop.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelDesktop_ControlAdded);
            this.panelDesktop.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelDesktop_ControlRemoved);
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitleBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(785, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tổng:";
            // 
            // tbTotal
            // 
            this.tbTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotal.DefaultText = "";
            this.tbTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbTotal.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.tbTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotal.Enabled = false;
            this.tbTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.ForeColor = System.Drawing.Color.LightGray;
            this.tbTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotal.Location = new System.Drawing.Point(846, 351);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.PasswordChar = '\0';
            this.tbTotal.PlaceholderText = "";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.SelectedText = "";
            this.tbTotal.Size = new System.Drawing.Size(223, 36);
            this.tbTotal.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Số loại sách";
            // 
            // tbNumDiverse
            // 
            this.tbNumDiverse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumDiverse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNumDiverse.DefaultText = "";
            this.tbNumDiverse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumDiverse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumDiverse.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.tbNumDiverse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumDiverse.Enabled = false;
            this.tbNumDiverse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumDiverse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumDiverse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumDiverse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumDiverse.Location = new System.Drawing.Point(3, 370);
            this.tbNumDiverse.Name = "tbNumDiverse";
            this.tbNumDiverse.PasswordChar = '\0';
            this.tbNumDiverse.PlaceholderText = "";
            this.tbNumDiverse.ReadOnly = true;
            this.tbNumDiverse.SelectedText = "";
            this.tbNumDiverse.Size = new System.Drawing.Size(83, 30);
            this.tbNumDiverse.TabIndex = 46;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuantity.DefaultText = "";
            this.tbQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.tbQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantity.Enabled = false;
            this.tbQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.ForeColor = System.Drawing.Color.LightGray;
            this.tbQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantity.Location = new System.Drawing.Point(534, 370);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.PasswordChar = '\0';
            this.tbQuantity.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.PlaceholderText = "";
            this.tbQuantity.ReadOnly = true;
            this.tbQuantity.SelectedText = "";
            this.tbQuantity.Size = new System.Drawing.Size(111, 30);
            this.tbQuantity.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(539, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Số lượng sách";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rjbtnCancel
            // 
            this.rjbtnCancel.BackColor = System.Drawing.Color.DimGray;
            this.rjbtnCancel.BackgroundColor = System.Drawing.Color.DimGray;
            this.rjbtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnCancel.BorderRadius = 20;
            this.rjbtnCancel.BorderSize = 0;
            this.rjbtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnCancel.FlatAppearance.BorderSize = 0;
            this.rjbtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnCancel.ForeColor = System.Drawing.Color.White;
            this.rjbtnCancel.Location = new System.Drawing.Point(615, 451);
            this.rjbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(150, 40);
            this.rjbtnCancel.TabIndex = 40;
            this.rjbtnCancel.Text = "Hủy";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            this.rjbtnCancel.Click += new System.EventHandler(this.rjbtnCancel_Click);
            // 
            // rjbtnBuy
            // 
            this.rjbtnBuy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.rjbtnBuy.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.rjbtnBuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnBuy.BorderRadius = 20;
            this.rjbtnBuy.BorderSize = 0;
            this.rjbtnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnBuy.FlatAppearance.BorderSize = 0;
            this.rjbtnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnBuy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.rjbtnBuy.ForeColor = System.Drawing.Color.White;
            this.rjbtnBuy.Location = new System.Drawing.Point(325, 451);
            this.rjbtnBuy.Name = "rjbtnBuy";
            this.rjbtnBuy.Size = new System.Drawing.Size(150, 40);
            this.rjbtnBuy.TabIndex = 39;
            this.rjbtnBuy.Text = "Mua sách";
            this.rjbtnBuy.TextColor = System.Drawing.Color.White;
            this.rjbtnBuy.UseVisualStyleBackColor = false;
            this.rjbtnBuy.Click += new System.EventHandler(this.rjbtnBuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOK.BorderRadius = 16;
            this.btnOK.BorderSize = 0;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(707, 63);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 31);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumber.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tbNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumber.BorderRadius = 0;
            this.tbNumber.BorderSize = 2;
            this.tbNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.ForeColor = System.Drawing.Color.LightGray;
            this.tbNumber.Location = new System.Drawing.Point(446, 63);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumber.Multiline = false;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNumber.PasswordChar = false;
            this.tbNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNumber.PlaceholderText = "Nhập";
            this.tbNumber.Size = new System.Drawing.Size(250, 31);
            this.tbNumber.TabIndex = 2;
            this.tbNumber.Texts = "";
            this.tbNumber.UnderlinedStyle = false;
            this.tbNumber._TextChanged += new System.EventHandler(this.tbNumber__TextChanged);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.tbNumDiverse;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.tbQuantity;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.tbTotal;
            // 
            // FormCart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1115, 503);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNumDiverse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rjbtnCancel);
            this.Controls.Add(this.rjbtnBuy);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMuaSach";
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.Label label2;
        private RJTextBox tbNumber;
        private RJButton btnOK;
        private System.Windows.Forms.Panel panelDesktop;
        private RJButton rjbtnBuy;
        private RJButton rjbtnCancel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbTotal;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbNumDiverse;
        private Guna.UI2.WinForms.Guna2TextBox tbQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}