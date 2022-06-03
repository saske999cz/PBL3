using DoAnPBL3.Models;
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
    public partial class FormAuthenticateCustomer : Form
    {

        public FormAuthenticateCustomer()
        {
            InitializeComponent();
        }

        private void FormAuthenticateCustomer_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void rjbtnOK_Click(object sender, EventArgs e)
        {
            if (tbConfirmPhone.Text.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập SĐT của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!Validators.IsValidPhoneNumber(tbConfirmPhone.Text, Validators.PHONE_REGEX))
                RJMessageBox.Show("SĐT không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    var customer = context.Customers
                        .Where(cus => cus.Phone == tbConfirmPhone.Text.Trim())
                        .Select(cus => new { cus.ID_Customer, cus.FullNameCustomer })
                        .ToList()
                        .FirstOrDefault();
                    if (customer == null)
                    {
                        DialogResult result = RJMessageBox.Show("Khách hàng hiện tại chưa có trong hệ thống. Xác nhận thêm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            new FormAddKH(tbConfirmPhone.Text).ShowDialog();
                            if (FormCart.ID_Customer != "")
                                Close();
                            else
                                return;
                        }
                        else
                            return;
                    }
                    else
                    {
                        RJMessageBox.Show("Khách hàng " + customer.FullNameCustomer + " có trong hệ thống", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormCart.ID_Customer = customer.ID_Customer;
                        Close();
                    }
                }
            }
        }

        private void rjbtnAdd_Click(object sender, EventArgs e)
        {
            new FormAddKH().ShowDialog();
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}