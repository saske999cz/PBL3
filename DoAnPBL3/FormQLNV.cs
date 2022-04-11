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
    public partial class FormQLNV : Form
    {
        public FormQLNV()
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
        private void btnAddNV_MouseEnter(object sender, EventArgs e)
        {
            btnAddNV.BackColor = RGBColors.color4;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = RGBColors.color4;
        }

        private void btnHienThiNV_MouseEnter(object sender, EventArgs e)
        {
            btnHienThiNV.BackColor = RGBColors.color4;
        }

        private void btnAddNV_MouseLeave(object sender, EventArgs e)
        {
            btnAddNV.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnDeleteNV_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = Color.FromArgb(31, 30, 68);
        }

        private void btnHienThiNV_MouseLeave(object sender, EventArgs e)
        {
            btnHienThiNV.BackColor = Color.FromArgb(31, 30, 68);
        }
    }
}
