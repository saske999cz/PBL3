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
    public partial class FormTTKH : Form
    {
        private readonly string ID_Customer;

        public FormTTKH(string ID_Customer)
        {
            InitializeComponent();
            this.ID_Customer = ID_Customer;
        }

        private void FormTTKH_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var infoCustomer = context.Customers
                    .Where(cus => cus.ID_Customer == ID_Customer)
                    .ToList()
                    .FirstOrDefault();
                tbNameKH.Text = infoCustomer.FullNameCustomer;
                tbGenderKH.Text = infoCustomer.Gender;
                tbPhoneKH.Text = infoCustomer.Phone;
                tbAddressKH.Text = infoCustomer.Address;
                var startDate = context.Orders
                    .Where(order => order.ID_Customer == ID_Customer)
                    .OrderBy(order => order.OrderDate)
                    .Select(order => order.OrderDate)
                    .FirstOrDefault();
                tbStartDate.Text = startDate.ToString("dd/MM/yyyy");
                var totalPrice = context.Customers
                    .Join(
                        context.Orders,
                        cus => cus.ID_Customer,
                        order => order.ID_Customer,
                        (cus, order) => new { cus.ID_Customer, order.TotalPrice })
                    .Where(cus => cus.ID_Customer == ID_Customer)
                    .Sum(order => order.TotalPrice);
                tbTotalPrice.Text = totalPrice.ToString("##,#") + "VNĐ";
                var numberOrder = context.Customers
                    .Join(
                        context.Orders,
                        cus => cus.ID_Customer,
                        order => order.ID_Customer,
                        (cus, order) => new { cus.ID_Customer, order.TotalPrice })
                    .Where(cus => cus.ID_Customer == ID_Customer)
                    .ToList()
                    .Count();
                tbNumberOrder.Text = numberOrder.ToString();
            }
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
