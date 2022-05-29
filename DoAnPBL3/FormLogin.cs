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
            using (BookStoreContext context = new BookStoreContext())
            {
                // tương tác với DB 1 lần để rend ra CSDL
                context.Languages.ToList();
            }
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
            }
            if (Properties.Settings.Default.role == "Quản Trị")
                radioAdmin.Checked = true;
            else
                radioEmployee.Checked = true;
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormForgotPassword(username, password, email, emailPassword));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                    using (var bookStore = new BookStoreContext())
                    {
                        var listAdminAccounts = bookStore.Accounts
                                                .Where(account => account.Role == true) // Admin
                                                .Where(account => account.Username == username)
                                                .Where(account => account.Password == password)
                                                .Select(account => new { account.Username, account.Password });
                        if (listAdminAccounts.ToList().Count > 0)
                        {
                            Hide();
                            if (cbSaveAcc.Checked)
                            {
                                Properties.Settings.Default.username = username;
                                Properties.Settings.Default.password = password;
                                Properties.Settings.Default.role = radioAdmin.Text;
                                Properties.Settings.Default.Save();
                            }
                            else
                                Properties.Settings.Default.Reset();
                            MainMenuQTV mainMenuQTV = new MainMenuQTV(listAdminAccounts.ToList().FirstOrDefault().Username);
                            mainMenuQTV.ShowDialog();
                            Close();
                        }
                        else
                            RJMessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    using (var bookStore = new BookStoreContext())
                    {
                        var listEmployeeAccounts = bookStore.Accounts
                                                .Where(account => account.Role == false) // Employee
                                                .Where(account => account.Username == username)
                                                .Where(account => account.Password == password)
                                                .Select(account => new { account.Username, account.Password });
                        if (listEmployeeAccounts.ToList().Count > 0)
                        {
                            Hide();
                            if (cbSaveAcc.Checked)
                            {
                                Properties.Settings.Default.username = username;
                                Properties.Settings.Default.password = password;
                                Properties.Settings.Default.role = radioEmployee.Text;
                                Properties.Settings.Default.Save();
                            }
                            else
                                Properties.Settings.Default.Reset();
                            MainMenuNV mainMenuNV = new MainMenuNV(listEmployeeAccounts.ToList().FirstOrDefault().Username);
                            mainMenuNV.ShowDialog();
                            Close();
                        }
                        else
                            RJMessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
                ShowPass.BringToFront();
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '●';
                HidePass.BringToFront();
            }
        }
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
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
