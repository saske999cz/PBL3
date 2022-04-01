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
    public partial class MenuQLDT : Form
    {
        public MenuQLDT()
        {
            InitializeComponent();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenuQTV q = new MainMenuQTV();
            q.ShowDialog();
            Close();
        }
    }
}
