using DoAnPBL3.BLL;
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

namespace DoAnPBL3
{
    public partial class FormHoaDonKhachHang : Form
    {
        private readonly string ID_Customer;
        private readonly string nameCustomer;
        public FormHoaDonKhachHang(string ID_Customer, string nameCustomer)
        {
            this.ID_Customer = ID_Customer;
            this.nameCustomer = nameCustomer;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void FormHoaDonKhachHang_Load(object sender, EventArgs e)
        {
            tbMaKH.Text = ID_Customer;
            tbNameKH.Text = nameCustomer;
            dgvQLHD.RowHeadersVisible = true;
            dgvQLHD.BorderStyle = BorderStyle.FixedSingle;
            dgvQLHD.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLHD.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            List<Order> listOrders = BLL_QLHD.Instance.GetOrdersByIDCustomer(ID_Customer);
            DataTable data = new DataTable();
            CreateCol(data);
            if (listOrders != null)
            {
                foreach (Order order in listOrders)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, order));
                }
                dgvQLHD.DataSource = data;
                totalBill.Text = BLL_QLHD.Instance.GetNumberTotalOrderByIDCustomer(ID_Customer).ToString();
                tbTotalPrice.Text = BLL_QLHD.Instance.GetNumberTotalPriceByIDCustomer(ID_Customer).ToString("##,#") + "VNĐ";
            }
            else
            {
                dgvQLHD.DataSource = null;
                totalBill.Text = "0";
                tbTotalPrice.Text = "0VNĐ";
            }
        }

        private void DgvQLHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string orderDate = dgvQLHD.CurrentRow.Cells["OrderDate"].Value.ToString();
            new FormChiTietHoaDon(GetID_Order(), orderDate).Show();
        }
        
        private string GetID_Order()
        {
            return dgvQLHD.CurrentRow.Cells["ID_Order"].Value.ToString();
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Order", typeof(string)),
                new DataColumn("OrderDate", typeof(string)),
                new DataColumn("NameEmployee", typeof(string)),
                new DataColumn("Total", typeof(string)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, Order order)
        {
            dataRow["ID_Order"] = order.ID_Order;
            dataRow["OrderDate"] = order.OrderDate.ToString("dd/MM/yyyy");
            dataRow["NameEmployee"] = BLL_QLNV.Instance.GetNameEmployeeByID(order.ID_Employee);
            dataRow["Total"] = order.TotalPrice.ToString("##,#") + "VNĐ";
            return dataRow;
        }
    }
}