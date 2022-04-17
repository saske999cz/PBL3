using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnPBL3.Models;

namespace DoAnPBL3
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        private string username;
        private string password;
        private string email;
        private string emailPassword;
        private Form currentChildForm;

        BookStoreContext bookStore;

        public FormLogin(string username = "", string password = "", string email = "", string emailPassword = "")
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.email = email;
            this.emailPassword = emailPassword;
        }


        private void Login_Load(object sender, EventArgs e)
        {
            bookStore = new BookStoreContext();
            bookStore.Languages.ToList(); // tương tác với DB 1 lần để rend ra CSDL
            if (Properties.Settings.Default.username != "")
                cbSaveAcc.Checked = true;
            if (username != "" || password != "")
            {
                txtUserName.Text = username;
                txtPassword.Text = password;
            }
            else
            {
                txtUserName.Text = Properties.Settings.Default.username;
                txtPassword.Text = Properties.Settings.Default.password;
                // btnLogin.PerformClick();
            }
        }


        private void cbSaveAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                if (cbSaveAcc.Checked)
                {
                    Properties.Settings.Default.username = txtUserName.Text;
                    Properties.Settings.Default.password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                    Properties.Settings.Default.Reset();
            }
        }


        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormSend_Code());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bookStore = new BookStoreContext();
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username.Trim() == "" && password.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập tên tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (username.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (password.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (radioAdmin.Checked)
                {
                    var listAdminAccounts = from account in bookStore.Accounts
                                            where (account.Role == EnumRole.Admin.ToString() && account.Username == username && account.Password == password)
                                            select new
                                            {
                                                account.Username,
                                                account.Password
                                            };
                    var listAdminUsernameAccounts = from account in bookStore.Accounts
                                                    where (account.Role == EnumRole.Admin.ToString() && account.Username == username)
                                                    select new
                                                    {
                                                        account.Username,
                                                    };
                    if (listAdminUsernameAccounts.ToList().Count > 0)
                    {
                        if ((listAdminAccounts.ToList()).Count > 0)
                        {
                            Hide();
                            MainMenuQTV mainMenuQTV = new MainMenuQTV();
                            mainMenuQTV.ShowDialog();
                            Close();
                        }
                        else
                            MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Tài khoản không tồn tại trong hệ thống quản trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var listEmployeeAccounts = from account in bookStore.Accounts
                                               where (account.Role == EnumRole.Employee.ToString() && account.Username == username && account.Password == password)
                                               select new
                                               {
                                                   account.Username,
                                                   account.Password
                                               };
                    var listEmployeeUsernameAccounts = from account in bookStore.Accounts
                                                       where (account.Role == EnumRole.Employee.ToString() && account.Username == username)
                                                       select new
                                                       {
                                                           account.Username,
                                                       };
                    if (listEmployeeUsernameAccounts.ToList().Count > 0)
                    {
                        if ((listEmployeeAccounts.ToList()).Count > 0)
                        {
                            Hide();
                            MainMenuNV mainMenuNV = new MainMenuNV();
                            mainMenuNV.ShowDialog();
                            Close();
                        }
                        else
                            MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Tài khoản không tồn tại trong hệ thống nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Show_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
                Show.BringToFront();
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '●';
                Hide.BringToFront();
            }
        }
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin.PerformClick();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            

        }
    }
}
