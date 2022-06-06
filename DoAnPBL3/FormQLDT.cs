using DoAnPBL3.Models;
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
        private readonly string ThemeColor;
        private Button btnCurrent;
        private readonly Dashboard model;
        public FormQLDT(string theme)
        {
            InitializeComponent();
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            ThemeColor = theme;

            model = new Dashboard();
            LoadData();
            switch (theme)
            {
                case "Admin":
                    btnOK.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    lblSellBook.ForeColor = Color.FromArgb(124, 141, 181);
                    lblRemainingBook.ForeColor = Color.FromArgb(124, 141, 181);
                    lblNumberCustomer.ForeColor = Color.FromArgb(124, 141, 181);
                    numberCustomer.ForeColor = Color.WhiteSmoke;
                    remainingBook.ForeColor = Color.WhiteSmoke;
                    sellBook.ForeColor = Color.WhiteSmoke;
                    lblNumberOrder.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalProfit.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalRevenue.ForeColor = Color.FromArgb(124, 141, 181);
                    totalProfit.ForeColor = Color.WhiteSmoke;
                    totalRevenue.ForeColor = Color.WhiteSmoke;
                    numberOrder.ForeColor = Color.WhiteSmoke;
                    lblEndDate.ForeColor = Color.Gainsboro;
                    lblStartDate.ForeColor = Color.Gainsboro;
                    lblBetween.ForeColor = Color.Gainsboro;
                    lblUnderstockBook.ForeColor = Color.Gainsboro;
                    lblStatistic.ForeColor = Color.Gainsboro;
                    btnCustomDate.ForeColor = Color.Gainsboro;
                    btnLast7Days.ForeColor = Color.Gainsboro;
                    btnThisMonth.ForeColor = Color.Gainsboro;
                    btnThisQuarter.ForeColor = Color.Gainsboro;
                    btnToday.ForeColor = Color.Gainsboro;
                    break;
                case "Dark":
                    btnOK.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    lblSellBook.ForeColor = Color.FromArgb(124, 141, 181);
                    lblRemainingBook.ForeColor = Color.FromArgb(124, 141, 181);
                    lblNumberCustomer.ForeColor = Color.FromArgb(124, 141, 181);
                    numberCustomer.ForeColor = Color.WhiteSmoke;
                    remainingBook.ForeColor = Color.WhiteSmoke;
                    sellBook.ForeColor = Color.WhiteSmoke;
                    lblNumberOrder.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalProfit.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalRevenue.ForeColor = Color.FromArgb(124, 141, 181);
                    totalProfit.ForeColor = Color.WhiteSmoke;
                    totalRevenue.ForeColor = Color.WhiteSmoke;
                    numberOrder.ForeColor = Color.WhiteSmoke;
                    lblEndDate.ForeColor = Color.Gainsboro;
                    lblStartDate.ForeColor = Color.Gainsboro;
                    lblBetween.ForeColor = Color.Gainsboro;
                    lblUnderstockBook.ForeColor = Color.Gainsboro;
                    lblStatistic.ForeColor = Color.Gainsboro;
                    btnCustomDate.ForeColor = Color.Gainsboro;
                    btnLast7Days.ForeColor = Color.Gainsboro;
                    btnThisMonth.ForeColor = Color.Gainsboro;
                    btnThisQuarter.ForeColor = Color.Gainsboro;
                    btnToday.ForeColor = Color.Gainsboro;                   
                    break;
                case "Light":
                    btnOK.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    lblSellBook.ForeColor = Color.Black;
                    lblRemainingBook.ForeColor = Color.Black;
                    lblNumberCustomer.ForeColor = Color.Black;
                    numberCustomer.ForeColor = Color.Black;
                    remainingBook.ForeColor = Color.Black;
                    sellBook.ForeColor = Color.Black;
                    lblNumberOrder.ForeColor = Color.Black;
                    lblTotalProfit.ForeColor = Color.Black;
                    lblTotalRevenue.ForeColor = Color.Black;
                    totalProfit.ForeColor = Color.Black;
                    totalRevenue.ForeColor = Color.Black;
                    numberOrder.ForeColor = Color.Black;
                    lblEndDate.ForeColor = Color.Black;
                    lblStartDate.ForeColor = Color.Black;
                    lblBetween.ForeColor = Color.Black;
                    lblUnderstockBook.ForeColor = Color.Black;
                    lblStatistic.ForeColor = Color.Black;
                    btnCustomDate.ForeColor = Color.Black;
                    btnLast7Days.ForeColor = Color.Black;
                    btnThisMonth.ForeColor = Color.Black;
                    btnThisQuarter.ForeColor = Color.Black;
                    btnToday.ForeColor = Color.Black;
                    chartGrossRevenue.Titles.Clear();
                    Title title = chartGrossRevenue.Titles.Add("Tổng doanh thu");
                    title.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                    title.ForeColor = Color.Black;
                    title.Alignment = ContentAlignment.MiddleLeft;

                    chartTopFiveBooks.Titles.Clear();
                    Title title2 = chartTopFiveBooks.Titles.Add("Top 5 sách bán chạy nhất");
                    title2.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                    title2.ForeColor = Color.Black;
                    title2.Alignment = ContentAlignment.MiddleLeft;
                    break;
            }
            btnOK.Hide();
            ActivateButton(btnLast7Days, Color.FromArgb(107, 83, 255));
        }

        private void FormQLDT_Load(object sender, EventArgs e)
        {
            dgvHHTLI.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvHHTLI.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        }

        private void LoadData()
        {
            bool refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData)
            {
                numberOrder.Text = model.NumOrders.ToString();
                totalRevenue.Text = model.ToTalRevenue.ToString() + "VNĐ";
                totalProfit.Text = model.TotalProfit.ToString() + "VNĐ";
                numberCustomer.Text = model.NumCustomers.ToString();
                remainingBook.Text = model.NumRemainingBooks.ToString();
                sellBook.Text = model.NumSellBooks.ToString();

                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.DataBind();

                chartTopFiveBooks.DataSource = model.TopBookLists;
                chartTopFiveBooks.DataBind();

                dgvHHTLI.DataSource = model.UnderstockBookList;
            }
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

        private void LblStartDate_Click(object sender, EventArgs e)
        {
            if (btnCurrent == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void LblEndDate_Click(object sender, EventArgs e)
        {
            if (btnCurrent == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }

        private void BtnCustomDate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            btnOK.Show();
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            dtpStartDate.Value = DateTime.Today.AddHours(0);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
        }

        private void BtnLast7Days_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
        }

        private void BtnThisMonth_Click(object sender, EventArgs e)
        {
            DisableButton();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
        }

        private void BtnThisQuarter_Click(object sender, EventArgs e)
        {
            DisableButton();
            if (DateTime.Today.Month >= 1 && DateTime.Today.Month <= 3)
                dtpStartDate.Value = new DateTime(DateTime.Today.Year, 1, 1);
            else if (DateTime.Today.Month >= 4 && DateTime.Today.Month <= 6)
                dtpStartDate.Value = new DateTime(DateTime.Today.Year, 4, 1);
            else if (DateTime.Today.Month >= 7 && DateTime.Today.Month <= 9)
                dtpStartDate.Value = new DateTime(DateTime.Today.Year, 7, 1);
            else
                dtpStartDate.Value = new DateTime(DateTime.Today.Year, 10, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            ActivateButton(sender, Color.FromArgb(107, 83, 255));
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
