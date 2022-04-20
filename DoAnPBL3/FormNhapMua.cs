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
        private int index { get; set; }
        public FormNhapMua(int index)
        {
            InitializeComponent();
            this.index = index;
            
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
            {
                tbNameBook.Text = "";
                tbPrice.Text = "";

            }
        }

        private void tbSL_TextChanged(object sender, EventArgs e)
        {
            if (tbSL.Text != "")
            {
                tbCP.Text = (Convert.ToInt64(tbSL.Text) * Convert.ToInt64(tbPrice.Text)).ToString();

            }

            else
                tbCP.Text = "";
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public long GetCP()
        {   long CP = 0;
            CP = Convert.ToInt64(tbCP.Text);
            return CP;
        }
        
    }
}
