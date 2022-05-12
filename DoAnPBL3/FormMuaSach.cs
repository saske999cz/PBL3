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
    public partial class FormMuaSach : Form
    {
        FormNhapMua[] currentChildForm;
        public FormMuaSach()
        {
            InitializeComponent();
        }

        private void OpenChildForm(FormNhapMua childForm)
        {



            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Top;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            long total = 0;
            if (tbNumber.Texts == "")
                RJMessageBox.Show("Vui lòng nhập số lượng loại sách muốn mua", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                for (int i = 0; i < Convert.ToInt32(tbNumber.Texts); i++)
                {
                    currentChildForm[i] = new FormNhapMua(i);

                }

                for (int i = 0; i < Convert.ToInt32(tbNumber.Texts); i++)
                {
                    OpenChildForm(currentChildForm[i]);

                }
            }
            for (int i = 0; i < Convert.ToInt32(tbNumber.Texts); i++)
            {
                total += currentChildForm[i].GetCP();

            }

            tbTotal.Text = total.ToString();

        }

        private void tbNumber__TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(tbNumber.Texts);
            foreach(byte b in asciiBytes)
            {
                if (b > 57 || b < 47)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {

                RJMessageBox.Show("Chỉ được nhập số", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumber.Texts = "";

            }

           
        }

        private void rjbtnBuy_Click(object sender, EventArgs e)
        {   if (tbNumber.Texts != "")
            {
                this.Alert("Mua sách thành công", Form_Alert.enmType.Success);
                this.Close();
            }
        else
                RJMessageBox.Show("Vui lòng nhập các thông tin cần thiết trước khi nhấn mua", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }
    }
}