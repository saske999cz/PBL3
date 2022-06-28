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
    public partial class FormChiTietHoaDon : Form
    {
        private readonly string ID_Order;
        private readonly string orderDate;

        public FormChiTietHoaDon(string ID_Order, string orderDate)
        {
            this.ID_Order = ID_Order;
            this.orderDate = orderDate;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvQLCTHD.RowHeadersVisible = true;
            dgvQLCTHD.BorderStyle = BorderStyle.FixedSingle;
            dgvQLCTHD.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLCTHD.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            tbIDHD.Text = ID_Order;
            tbOrderDate.Text = orderDate;
            List<OrderDetail> listOrderDetails = BLL_QLHD.Instance.GetOrderDetailsByIDOrder(ID_Order);
            DataTable data = new DataTable();
            CreateCol(data);
            if (listOrderDetails != null)
            {
                foreach (OrderDetail orderDetail in listOrderDetails)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, orderDetail));
                }
                dgvQLCTHD.DataSource = data;
                tbNumDiverse.Text = dgvQLCTHD.RowCount.ToString();
                tbQuantity.Text = BLL_QLHD.Instance.GetTotalQuantity(ID_Order).ToString();
                tbTotal.Text = BLL_QLHD.Instance.GetTotalAmount(ID_Order).ToString("##,#") + "VNĐ";
            }
            else
                dgvQLCTHD.DataSource = null;
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private string GetID_Book()
        {
            return dgvQLCTHD.CurrentRow.Cells["ID_Book"].Value.ToString();
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Book", typeof(string)),
                new DataColumn("NameBook", typeof(string)),
                new DataColumn("UnitPrice", typeof(string)),
                new DataColumn("Quantity", typeof(int)),
                new DataColumn("TotalAmount", typeof(string)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, OrderDetail orderDetail)
        {
            dataRow["ID_Book"] = orderDetail.ID_Book;
            dataRow["NameBook"] = orderDetail.NameBook;
            dataRow["UnitPrice"] = orderDetail.UnitPrice.ToString("##,#") + "VNĐ";
            dataRow["Quantity"] = orderDetail.Quantity;
            dataRow["TotalAmount"] = orderDetail.TotalAmount.ToString("##,#") + "VNĐ";
            return dataRow;
        }

        private void DgvQLCTHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTS(GetID_Book()).Show();
        }
    }
}