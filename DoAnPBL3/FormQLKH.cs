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
    public partial class FormQLKH : Form
    {
        public FormQLKH()
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

        private void btnTTKH_MouseEnter(object sender, EventArgs e)
        {
            btnTTKH.BackColor = RGBColors.color4;

        }

        private void btnTKKH_MouseEnter(object sender, EventArgs e)
        {
            btnTKKH.BackColor = RGBColors.color4;
        }

        private void btnTTHD_MouseEnter(object sender, EventArgs e)
        {
            btnTTHD.BackColor = RGBColors.color4;
        }

        private void btnTTKH_MouseLeave(object sender, EventArgs e)
        {
            btnTTKH.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnTKKH_MouseLeave(object sender, EventArgs e)
        {
            btnTKKH.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnTTHD_MouseLeave(object sender, EventArgs e)
        {
            btnTTHD.BackColor = Color.FromArgb(31, 30, 68);
        }
    }
}
