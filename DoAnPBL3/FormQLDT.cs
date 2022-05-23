using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnPBL3
{
    
    public partial class FormQLDT : Form
    {
        private string ThemeColor;
        private Button btnCurrent;
        public FormQLDT(string theme)
        {
            InitializeComponent();
            ThemeColor = theme;
            switch (theme)
            {
                case "Admin":
                    btnOK.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    label10.ForeColor = Color.FromArgb(124, 141, 181);
                    label8.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblCustomerNumber.ForeColor = Color.WhiteSmoke;
                    lblProductNumberConLai.ForeColor = Color.WhiteSmoke;
                    lblSellNumber.ForeColor = Color.WhiteSmoke;
                    lblNumberOfOrders.ForeColor = Color.FromArgb(124, 141, 181);
                    lblProfit.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalRevenue.ForeColor = Color.FromArgb(124, 141, 181);
                    lblProfitNumber.ForeColor = Color.WhiteSmoke;
                    lblTotalRevenueNumber.ForeColor = Color.WhiteSmoke;
                    lblOrderNumber.ForeColor = Color.WhiteSmoke;
                    lblEndDate.ForeColor = Color.Gainsboro;
                    lblStartDate.ForeColor = Color.Gainsboro;
                    label4.ForeColor = Color.Gainsboro;
                    label18.ForeColor = Color.Gainsboro;
                    label6.ForeColor = Color.Gainsboro;
                    btnCustomDate.ForeColor = Color.Gainsboro;
                    btnLast7Days.ForeColor = Color.Gainsboro;
                    btnThisMonth.ForeColor = Color.Gainsboro;
                    btnThisQuarter.ForeColor = Color.Gainsboro;
                    btnToday.ForeColor = Color.Gainsboro;
                    break;
                case "Dark":
                    btnOK.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    label10.ForeColor = Color.FromArgb(124, 141, 181);
                    label8.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblCustomerNumber.ForeColor = Color.WhiteSmoke;
                    lblProductNumberConLai.ForeColor = Color.WhiteSmoke;
                    lblSellNumber.ForeColor = Color.WhiteSmoke;
                    lblNumberOfOrders.ForeColor = Color.FromArgb(124, 141, 181);
                    lblProfit.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalRevenue.ForeColor = Color.FromArgb(124, 141, 181);
                    lblProfitNumber.ForeColor = Color.WhiteSmoke;
                    lblTotalRevenueNumber.ForeColor = Color.WhiteSmoke;
                    lblOrderNumber.ForeColor = Color.WhiteSmoke;
                    lblEndDate.ForeColor = Color.Gainsboro;
                    lblStartDate.ForeColor = Color.Gainsboro;
                    label4.ForeColor = Color.Gainsboro;
                    label18.ForeColor = Color.Gainsboro;
                    label6.ForeColor = Color.Gainsboro;
                    btnCustomDate.ForeColor = Color.Gainsboro;
                    btnLast7Days.ForeColor = Color.Gainsboro;
                    btnThisMonth.ForeColor = Color.Gainsboro;
                    btnThisQuarter.ForeColor = Color.Gainsboro;
                    btnToday.ForeColor = Color.Gainsboro;                   
                    break;
                case "Light":
                    btnOK.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    label10.ForeColor = Color.FromArgb(124, 141, 181);
                    label8.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblCustomerNumber.ForeColor = Color.Black;
                    lblProductNumberConLai.ForeColor = Color.Black;
                    lblSellNumber.ForeColor = Color.Black;
                    lblNumberOfOrders.ForeColor = Color.FromArgb(124, 141, 181);
                    lblProfit.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalRevenue.ForeColor = Color.FromArgb(124, 141, 181);
                    lblProfitNumber.ForeColor = Color.Black;
                    lblTotalRevenueNumber.ForeColor = Color.Black;
                    lblOrderNumber.ForeColor = Color.Black;
                    lblEndDate.ForeColor = Color.Black;
                    lblStartDate.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label18.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    btnCustomDate.ForeColor = Color.Black;
                    btnLast7Days.ForeColor = Color.Black;
                    btnThisMonth.ForeColor = Color.Black;
                    btnThisQuarter.ForeColor = Color.Black;
                    btnToday.ForeColor = Color.Black;
                    chartTDT.Titles.Clear();
                    Title title = chartTDT.Titles.Add("Tổng doanh thu");
                    title.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                    title.ForeColor = Color.Black;
                    title.Alignment = ContentAlignment.MiddleLeft;

                    chartTop5Sach.Titles.Clear();
                    Title title2 = chartTop5Sach.Titles.Add("Top 5 sách bán chạy nhất");
                    title2.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                    title2.ForeColor = Color.Black;
                    title2.Alignment = ContentAlignment.MiddleLeft;
                    break;
            }
            btnOK.Hide();
            ActivateButton(btnToday, Color.FromArgb(107, 83, 255));
           
        }

        private void DisableButton()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.Transparent;
                switch (ThemeColor)
                {
                    case "Dark":
                        btnCurrent.ForeColor = Color.Gainsboro;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;

                        btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
                        break;
                    case "Admin":
                        btnCurrent.ForeColor = Color.Gainsboro;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;

                        btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
                        break;
                    case "Light":
                        btnCurrent.ForeColor = Color.Black;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;

                        btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
                        break;
                }
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
    }
}
