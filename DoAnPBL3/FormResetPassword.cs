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
    public partial class FormResetPassword : Form
    {
        private string email = FormSendCode.toAddress;
        private string username;
        private string password;

        private BookStoreContext bookStore;

        public FormResetPassword(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }
        private void exitIcon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chưa hoàn thành thay đổi mật khẩu. Xác nhận muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Close();
            else
                return;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chưa hoàn thành thay đổi mật khẩu. Xác nhận muốn quay về màn đăng nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Hide();
                Login login = new Login(username, password);
                login.ShowDialog();
                Close();
            }
            else
                return;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() == "" && txtConfirmNewPassword.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập mật khẩu mới và xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtNewPassword.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtConfirmNewPassword.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtNewPassword.Text == txtConfirmNewPassword.Text)
            {
                if (changePassword(txtNewPassword.Text))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    Hide();
                    Login login = new Login(username, password);
                    login.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                MessageBox.Show("Mật khẩu xác nhận không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool changePassword(string newPassword)
        {
            bookStore = new BookStoreContext();
            var acc = (from account in bookStore.Accounts where account.Email == email select account).First();
            // Nếu trùng password cũ -> false
            if (acc.Password == newPassword)
                return false; 
            else
            {
                acc.Password = newPassword;
                bookStore.SaveChanges();
                return true;
            }
        }

        private void blueEyeIcon_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.PasswordChar == '*')
            {
                txtNewPassword.PasswordChar = '\0';
                txtConfirmNewPassword.PasswordChar = '\0';
                blueEyeSlashIcon.BringToFront();
            }
        }

        private void blueEyeSlashIcon_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.PasswordChar == '\0')
            {
                txtNewPassword.PasswordChar = '*';
                txtConfirmNewPassword.PasswordChar = '*';
                blueEyeIcon.BringToFront();
            }
        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnConfirm.PerformClick();
        }

        private void txtConfirmNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnConfirm.PerformClick();
        }
    }
}
