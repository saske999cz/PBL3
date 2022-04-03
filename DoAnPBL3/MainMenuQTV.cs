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
    public partial class MainMenuQTV : Form
    {
        public MainMenuQTV()
        {
            InitializeComponent();
        }

        private void BtnQLNV_Click(object sender, EventArgs e)
        {
            Hide();
            MenuQLNV a = new MenuQLNV();
            a.ShowDialog();
            Close();
        }

        private void BtnQLS_Click(object sender, EventArgs e)
        {
            Hide();
            MenuQLBS b = new MenuQLBS();
            b.ShowDialog();
            Close();
        }

        private void BtnQLDT_Click(object sender, EventArgs e)
        {
            Hide();
            MenuQLDT d = new MenuQLDT();
            d.ShowDialog();
            Close();
        }

        private void BtnQLKH_Click(object sender, EventArgs e)
        {
            Hide();
            MenuQLKH k = new MenuQLKH();
            k.ShowDialog();
            Close();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }
    }
}
