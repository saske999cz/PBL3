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
    public partial class FormQLDT : Form
    {
        private Button btnCurrent;
        public FormQLDT()
        {
            InitializeComponent();
            btnOK.Hide();
        }

        private void DisableButton()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(34, 31, 46);
                btnCurrent.ForeColor = Color.Gainsboro;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;

                btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
                if (btnCurrent == btnCustomDate)
                {
                    btnOK.Hide();
                }
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {

                DisableButton();
                // Button
                btnCurrent = (Button)senderBtn;
                btnCurrent.BackColor = color;
                btnCurrent.ForeColor = Color.Gainsboro;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;

                btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
            }
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

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            if (btnCurrent == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if (btnCurrent == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            btnOK.Show();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
        }

        private void btnThisQuarter_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
        }

        private void lblCustomerNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
