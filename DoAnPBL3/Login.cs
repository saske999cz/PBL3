using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        BookStoreContext BookStore;

        private void Login_Load(object sender, EventArgs e)
        {
            BookStore = new BookStoreContext();
            BookStore.Languages.ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BookStoreContext db = new BookStoreContext();
            var listAdminAccounts = from account in db.Accounts
                                    select new
                                    {
                                        
                                    };
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var result = from account in db.Accounts
                             where (account.Username == username && account.Password == password)
                             select new
                             {
                                 account.Username,
                                 account.Password
                             };
                if (result.ToList().Count > 0)
                {
                    MainMenuQTV mainMenuQTV = new MainMenuQTV();
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    Hide();
                    mainMenuQTV.Show();
                }   
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSendCode formSendCode = new FormSendCode();
            Hide();
            formSendCode.Show();
        }
    }
}