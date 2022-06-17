using DoAnPBL3.Validator;
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
        public FormQLKH(string theme)
        {
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    btnTKKH.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblKHN.ForeColor = Color.White;
                    lblKHNu.ForeColor = Color.White;
                    lblTSKH.ForeColor = Color.White;
                    xuiSegmentKH.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentKH.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentKH.SegmentColor = Color.DarkMagenta;
                    xuiSegmentKH.SegmentInactiveTextColor = Color.White;
                    btnTKKH.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKKH.BackColor = Color.FromArgb(23, 21, 35);
                    rjtbTKKH.BorderColor = Color.FromArgb(23, 21, 35);
                    rjtbTKKH.ForeColor = Color.Silver;
                    rjtbTKKH.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLKH.BackgroundColor = Color.FromArgb(24, 37, 65);
                    break;
                case "Dark":
                    btnTKKH.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblKHN.ForeColor = Color.White;
                    lblKHNu.ForeColor = Color.White;
                    lblTSKH.ForeColor = Color.White;
                    xuiSegmentKH.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentKH.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentKH.SegmentColor = Color.DarkMagenta;
                    xuiSegmentKH.SegmentInactiveTextColor = Color.White;
                    btnTKKH.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKKH.BackColor = Color.FromArgb(18, 18, 18);
                    rjtbTKKH.BorderColor = Color.FromArgb(18, 18, 18);
                    rjtbTKKH.ForeColor = Color.Silver;
                    rjtbTKKH.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLKH.BackgroundColor = Color.FromArgb(34, 31, 46);
                    break;
                case "Light":
                    btnTKKH.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    label2.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    lblKHN.ForeColor = Color.Black;
                    lblKHNu.ForeColor = Color.Black;
                    lblTSKH.ForeColor = Color.Black;
                    xuiSegmentKH.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentKH.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentKH.SegmentColor = Color.DarkMagenta;
                    xuiSegmentKH.SegmentInactiveTextColor = Color.White;
                    btnTKKH.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKKH.BackColor = Color.FromArgb(255, 255, 255);
                    rjtbTKKH.BorderColor = Color.FromArgb(180, 180, 180);
                    rjtbTKKH.ForeColor = Color.DimGray;
                    rjtbTKKH.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLKH.BackgroundColor = Color.Silver;
                    break;
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

        private void BtnHDKH_MouseEnter(object sender, EventArgs e)
        {
            btnHDKH.BackColor = RGBColors.color4;
        }

        private void BtnHDKH_MouseLeave(object sender, EventArgs e)
        {
            btnHDKH.BackColor = Color.RoyalBlue;
        }

        private void FormQLKH_Load(object sender, EventArgs e)
        {
            dgvQLKH.RowHeadersVisible = true;
            dgvQLKH.BorderStyle = BorderStyle.FixedSingle;
            dgvQLKH.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLKH.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            using (BookStoreContext context = new BookStoreContext())
            {
                var listCustomers = context.Customers
                    .Select(customer => new
                    {
                        customer.ID_Customer,
                        customer.FullNameCustomer,
                        customer.Gender,
                        customer.Phone,
                        customer.Address
                    });
                var listMaleCustomers = listCustomers.Where(customer => customer.Gender == "Nam");
                var listFemaleCustomers = listCustomers.Where(customer => customer.Gender == "Nữ");
                dgvQLKH.DataSource = listCustomers.ToList();
                lblTSKH.Text = listCustomers.Count().ToString();
                lblKHN.Text = listMaleCustomers.Count().ToString();
                lblKHNu.Text = listFemaleCustomers.Count().ToString();
                dgvQLKH.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            }
        }

        private void XuiSegmentKH_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listCustomers = context.Customers
                        .Select(customer => new
                        {
                            customer.ID_Customer,
                            customer.FullNameCustomer,
                            customer.Gender,
                            customer.Phone,
                            customer.Address
                        })
                        .ToList();
                var listMaleCustomers = listCustomers.Where(customer => customer.Gender == "Nam").ToList();
                var listFemaleCustomers = listCustomers.Where(customer => customer.Gender == "Nữ").ToList();
                lblTSKH.Text = listCustomers.Count().ToString();
                lblKHN.Text = listMaleCustomers.Count().ToString();
                lblKHNu.Text = listFemaleCustomers.Count().ToString();
                // Tất cả
                if (xuiSegmentKH.SelectedIndex == 0)
                    dgvQLKH.DataSource = listCustomers;
                // Nam
                else if (xuiSegmentKH.SelectedIndex == 1)
                    dgvQLKH.DataSource = listMaleCustomers;
                // Nữ
                else
                    dgvQLKH.DataSource = listFemaleCustomers;
            }
        }

        private void BtnHDKH_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("Hóa đơn khách hàng");
        }

        private void RjtbTKKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTKKH.PerformClick();
                e.Handled = true;
            }
        }

        private void BtnTKKH_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                if (rjtbTKKH.Texts.Trim() == "")
                {
                    RJMessageBox.Show("Vui lòng điền thông tin khách hàng cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Validators.IsValidPhoneNumber(rjtbTKKH.Texts, Validators.PHONE_REGEX))
                {
                    var listCustomers = context.Customers
                        .Where(customer => customer.Phone == rjtbTKKH.Texts)
                        .Select(customer => new
                        {
                            customer.ID_Customer,
                            customer.FullNameCustomer,
                            customer.Gender,
                            customer.Phone,
                            customer.Address
                        })
                        .ToList();
                    if (listCustomers.Count == 0)
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dgvQLKH.DataSource = listCustomers;
                }
                else
                {
                    var listCustomers = context.Customers
                        .Where(customer => customer.FullNameCustomer.Contains(rjtbTKKH.Texts))
                        .Select(customer => new
                        {
                            customer.ID_Customer,
                            customer.FullNameCustomer,
                            customer.Gender,
                            customer.Phone,
                            customer.Address
                        })
                        .ToList();
                    if (listCustomers.Count == 0)
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dgvQLKH.DataSource = listCustomers;
                }
            }
        }

        private void DgvQLKH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Customer = dgvQLKH.CurrentRow.Cells["ID_Customer"].Value.ToString();
            new FormTTKH(ID_Customer).ShowDialog();
        }
    }
}