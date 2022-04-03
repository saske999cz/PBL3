using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using FluentEmail.Smtp;
using FluentEmail.Core;

namespace DoAnPBL3
{
    public partial class FormSendCode : Form
    {
        private string username;
        private string password;

        string randomCode = Convert.ToString(0);
        public static string toAddress; // Địa chỉ Email (from -> to)
        private const string EMAIL_REGEX = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

        private BookStoreContext bookStore;

        public FormSendCode(string username = "", string password = "", string email = "", string emailPassword = "")
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            txtSendCode.Text = email;
            txtEmailPassword.Text = emailPassword;
        }
        private void exitIcon_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Close();
            else
                return;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (randomCode != "0")
            {
                DialogResult dialogResult = MessageBox.Show("Mã xác thực đã gửi đi sẽ không còn hiệu lực nếu về màn đăng nhập. Xác nhận quay về?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Hide();
                    Login login = new Login(username, password, txtSendCode.Text, txtEmailPassword.Text);
                    login.ShowDialog();
                    Close();
                }
                else return;
            }
            else
            {
                Hide();
                Login login = new Login(username, password, txtSendCode.Text, txtEmailPassword.Text);
                login.ShowDialog();
                Close();
            }
        }

        private void btnSendCode_ClickAsync(object sender, EventArgs e)
        {
            bookStore = new BookStoreContext();

            Random rand = new Random();

            if (txtSendCode.Text.Trim() == "" && txtEmailPassword.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập email và mật khẩu email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtSendCode.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtEmailPassword.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập mật khẩu email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (!Regex.IsMatch(txtSendCode.Text, EMAIL_REGEX))
                    MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var listEmail = from account in bookStore.Accounts where account.Email == txtSendCode.Text select new { account.Email };
                    if (listEmail.ToList().Count == 0)
                        MessageBox.Show("Không tìm thấy email trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        randomCode = (rand.Next(999999)).ToString();
                        MailMessage mailMessage = new MailMessage();
                        mailMessage.From = new MailAddress("BookShop@gmail.com");
                        mailMessage.To.Add(txtSendCode.Text);
                        mailMessage.Body = "Mã xác nhận là " + randomCode;
                        mailMessage.Subject = "Xác nhận thay đổi mật khẩu";

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(txtSendCode.Text, txtEmailPassword.Text);
                        try
                        {
                            smtp.Send(mailMessage);
                            MessageBox.Show("Gửi mã xác nhận thành công. Vui lòng check mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hệ thống gửi mail đang bảo trì. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (randomCode == "0")
                MessageBox.Show("Bạn chưa hoàn thành bước gửi mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                if (txtVerifyCode.Text.Trim() == "")
                    MessageBox.Show("Vui lòng nhập mã xác thực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (randomCode == txtVerifyCode.Text)
                    {
                        toAddress = txtSendCode.Text;
                        Hide();
                        FormResetPassword formResetPassword = new FormResetPassword(username, password);
                        formResetPassword.ShowDialog();
                        Close();
                    }
                    else
                        MessageBox.Show("Sai mã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void blueEyeIcon_Click(object sender, EventArgs e)
        {
            if (txtEmailPassword.PasswordChar == '*')
            {
                txtEmailPassword.PasswordChar = '\0';
                blueEyeSlashIcon.BringToFront();
            }
        }

        private void blueEyeSlashIcon_Click(object sender, EventArgs e)
        {
            if (txtEmailPassword.PasswordChar == '\0')
            {
                txtEmailPassword.PasswordChar = '*';
                blueEyeIcon.BringToFront();
            }
        }
    }
}
