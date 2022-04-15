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
    public partial class FormQLBS : Form
    {
        public FormQLBS()
        {
            InitializeComponent();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void btnTKS_MouseEnter(object sender, EventArgs e)
        {
            btnTKS.BackColor = RGBColors.color4;

        }

        private void btnSXS_MouseEnter(object sender, EventArgs e)
        {
            btnSXS.BackColor = RGBColors.color4;
        }

        private void btnHDTN_MouseEnter(object sender, EventArgs e)
        {
            btnHDTN.BackColor = RGBColors.color4;
        }

        private void btnTKS_MouseLeave(object sender, EventArgs e)
        {
            btnTKS.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnSXS_MouseLeave(object sender, EventArgs e)
        {
            btnSXS.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnHDTN_MouseLeave(object sender, EventArgs e)
        {
            btnHDTN.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnSXS_Click(object sender, EventArgs e)
        {
            rjDropDownMenuSXS.Show(btnSXS, new Point(0, btnSXS.Height));
        }

        private void FormQLBS_Load(object sender, EventArgs e)
        {
            rjDropDownMenuSXS.IsMainMenu = false;
        }

        private void rjtbTKNV__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
