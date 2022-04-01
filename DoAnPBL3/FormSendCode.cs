using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        string randomCode;
        public static string toAddress; // Địa chỉ Email (from -> to)
        public FormSendCode()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.Show();
        }

        private void btnSendCode_ClickAsync(object sender, EventArgs e)
        {           
            BookStoreContext db = new BookStoreContext();

            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();

            var listEmail = from account in db.Accounts select new { account.Email };

            if (listEmail.ToList().Count == 0)
            {
                MessageBox.Show("Không tìm thấy email trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MailMessage mailMessage = new MailMessage();
                toAddress = txtSendCode.Text;
                mailMessage.From = new MailAddress("BookShop@gmail.com");
                mailMessage.To.Add(toAddress);
                mailMessage.Body = "Mã xác nhận là " + randomCode;
                mailMessage.Subject = "Xác nhận thay đổi mật khẩu";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("lelong.ll32@gmail.com", "ruby29122010");
                try
                {
                    smtp.Send(mailMessage);
                    MessageBox.Show("Đã gửi mã xác nhận thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }               
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (randomCode == txtVerifyCode.Text)
            {
                toAddress = txtSendCode.Text;
                FormResetPassword formResetPassword = new FormResetPassword();
                Hide();
                formResetPassword.Show();
            }
            else
            {
                MessageBox.Show("Sai mã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        
    }
}
