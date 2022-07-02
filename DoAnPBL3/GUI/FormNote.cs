using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormNote : Form
    {
        public FormNote(string theme)
        {
            InitializeComponent();
            Text = "Ghi chú";
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(34, 33, 74);
                    lblTitle.ForeColor = Color.White;
                    tbTitle.ForeColor = Color.White;
                    tbTitle.PlaceholderForeColor = Color.White;
                    lblContent.ForeColor = Color.White;
                    tbContent.ForeColor = Color.White;
                    tbContent.PlaceholderForeColor = Color.White;
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(32, 32, 32);
                    lblTitle.ForeColor = Color.White;
                    tbTitle.ForeColor = Color.White;
                    tbTitle.FillColor = Color.FromArgb(40, 35, 40);
                    tbTitle.PlaceholderForeColor = Color.White;
                    lblContent.ForeColor = Color.White;
                    tbContent.ForeColor = Color.White;
                    tbContent.FillColor = Color.FromArgb(40, 35, 40);
                    tbContent.PlaceholderForeColor = Color.White;
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    lblTitle.ForeColor = Color.Black;
                    tbTitle.ForeColor = Color.Black;
                    tbTitle.BorderColor = Color.Black;
                    tbTitle.PlaceholderForeColor = Color.Black;
                    tbTitle.FillColor = Color.Silver;
                    lblContent.ForeColor = Color.Black;
                    tbContent.ForeColor = Color.Black;
                    tbContent.BorderColor = Color.Black;
                    tbContent.FillColor = Color.Silver;
                    tbContent.PlaceholderForeColor = Color.Black;
                    break;
            }
        }

        public string GetTitle()
        {
            return tbTitle.Text;
        }

        public string GetContent()
        {
            return tbContent.Text;
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            rjbtnOK.Parent.Parent.Text = "Changed";
            Hide();
            Alert("Đã thêm ghi chú mới", Form_Alert.EnmType.Success);
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "" || tbContent.Text != "")
            {
                DialogResult result = RJMessageBox.Show("Ghi chú chưa được lưu. Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Hide();
                else
                    return;
            }
            else
                Hide();
        }
    }
}
