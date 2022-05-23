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
    public partial class FormNhapMua : Form
    {
        private int index;
        public FormNhapMua(int index)
        {
            InitializeComponent();
            this.index = index;
            Index.Text = index.ToString();
            if(index > 9)
            {
                Index.Location = new Point(3, 16);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("You pressed the button");
        }

        private void tbIDBook_TextChanged(object sender, EventArgs e)
        {
            if (tbIDBook.Text == "1")
            {
                tbNameBook.Text = "abc";
                tbPrice.Text = "40000";
            }
            else
            if (tbIDBook.Text == "2")
            {
                tbNameBook.Text = "kkk";
                tbPrice.Text = "50000";
            }
            else
            if (tbIDBook.Text == "3")
            {
                tbNameBook.Text = "ooo";
                tbPrice.Text = "60000";
            }
            else
            if(tbIDBook.Text == "4")
            {
                tbNameBook.Text = "iii";
                tbPrice.Text = "70000";
            }
            else
            {
                tbNameBook.Text = "";
                tbPrice.Text = "";
            }
        }

        private void tbSL_TextChanged(object sender, EventArgs e)
        {
            
            bool flag = true;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(tbSL.Text);
            foreach (byte b in asciiBytes)
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
                tbSL.Text = "";
            }
            else
            {
                if (tbSL.Text != "")
                {
                    if (tbPrice.Text == "")
                    {
                        RJMessageBox.Show("ID sách không hợp lệ", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbSL.Text = "";
                    }
                    else
                        tbCP.Text = (Convert.ToInt64(tbSL.Text) * Convert.ToInt64(tbPrice.Text)).ToString();
                }
                else
                    tbCP.Text = "";
                Parent.Refresh();
            }
            Parent.Refresh();
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public long GetCP()
        {   long CP = 0;
            if (tbCP.Text != "")
                CP = Convert.ToInt64(tbCP.Text);
            else
                CP = 0;
            return CP;
        }

        public string GetCPText()
        {
            return tbCP.Text;
        }
        
        public int GetSL()
        {
            int SL = 0;
            if (tbSL.Text != "")
                SL = Convert.ToInt32(tbSL.Text);
            return SL;
        }
        public string GetSLText()
        {
            return tbSL.Text;
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        public void SetIndexText()
        {
            Index.Text = index.ToString();
        }

        public int GetIndex()
        {
            return index;
        }

        public void TextChanged()
        {  
            Index.Refresh();
        }

        private void Index_Paint(object sender, PaintEventArgs e)
        {
            Index.Text = index.ToString();
        }
    }
}
