using DoAnPBL3.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormSettingAccountQTV : Form
    {
        private string accountUsername;
        public FormSettingAccountQTV(string theme, string accountUsername)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
            switch (theme)
            {
                case "Admin":
                    btnEditImg.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    btnSaveChange.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    lblPassword.ForeColor = Color.White;
                    lblAvatar.ForeColor = Color.White;
                    lblConfirmPassword.ForeColor = Color.White;
                    tbPassword.FillColor = Color.White;
                    tbPassword.BorderColor = Color.White;
                    break;
                case "Dark":
                    btnEditImg.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    btnSaveChange.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    lblPassword.ForeColor = Color.White;
                    lblAvatar.ForeColor = Color.White;
                    lblConfirmPassword.ForeColor = Color.White;
                    tbPassword.FillColor = Color.White;
                    tbPassword.BorderColor = Color.White;
                    break;
                case "Light":
                    btnEditImg.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    btnSaveChange.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    lblPassword.ForeColor = Color.Black;
                    lblAvatar.ForeColor = Color.Black;
                    lblConfirmPassword.ForeColor = Color.Black;
                    tbPassword.FillColor = Color.White;
                    tbPassword.BorderColor = Color.White;
                    break;
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private byte[] ImageToByteArray(Guna2PictureBox pictureBox)
        {
            using (Bitmap bitmap = new Bitmap(pictureBox.ImageLocation))
            {
                MemoryStream memoryStream = new MemoryStream();
                try
                {
                    bitmap.Save(memoryStream, ImageFormat.Bmp);
                }
                catch (ExternalException)
                {
                    RJMessageBox.Show("Lỗi không thể lưu được ảnh. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                return memoryStream.ToArray();
            }
        }

        private void btnEditImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            if (pbAvatar.ImageLocation != null)
            {
                pbAvatar.ImageLocation = "";
                pbAvatar.Image = null;
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            string newPassword = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            byte[] newAvatar;
            bool isEqualToOldPassword = true, isConfirmPassMatchToNewPass = false;
            using (BookStoreContext context = new BookStoreContext())
            {
                // Validate password
                var oldPassword = context.Accounts
                    .Where(acc => acc.Username == accountUsername)
                    .Where(acc => acc.Password == newPassword)
                    .Select(acc => acc)
                    .ToList();
                if (newPassword == "")
                {
                    msgValidateNewPassword.ForeColor = Color.Red;
                    msgValidateNewPassword.Text = "Mật khẩu mới không được để trống";
                }
                else
                {
                    if (oldPassword.Count() > 0)
                    {
                        msgValidateNewPassword.ForeColor = Color.Red;
                        msgValidateNewPassword.Text = "Mật khẩu mới không được trùng mật khẩu cũ";
                        isEqualToOldPassword = true;
                    }
                    else
                    {
                        msgValidateNewPassword.ForeColor = Color.White;
                        msgValidateNewPassword.Text = "";
                        isEqualToOldPassword = false;
                    }
                    if (confirmPassword != newPassword)
                    {
                        msgValidateConfirmPassword.ForeColor = Color.Red;
                        msgValidateConfirmPassword.Text = "Mật khẩu xác nhận không khớp";
                        isConfirmPassMatchToNewPass = false;
                    }
                    else
                    {
                        msgValidateConfirmPassword.ForeColor = Color.White;
                        msgValidateConfirmPassword.Text = "";
                        isConfirmPassMatchToNewPass = true;
                    }
                }
                // Validate image
                if (pbAvatar.ImageLocation == "" || pbAvatar.ImageLocation == null)
                {
                    newAvatar = null;
                }
                else
                {
                    try
                    {
                        newAvatar = ImageToByteArray(pbAvatar);
                    }
                    catch (ExternalException)
                    {
                        return;
                    }
                }
                if (!isEqualToOldPassword && isConfirmPassMatchToNewPass)
                {
                    DialogResult dialogResult = RJMessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Account account = context.Accounts.Find(accountUsername);
                        account.Password = newPassword;
                        account.Avatar = newAvatar;
                        // Update to DB
                        context.SaveChanges();
                        Alert("Lưu mới dữ liệu thành công", Form_Alert.enmType.Success);
                        Close();
                    }
                    else
                        return;
                }
                else
                    return;
            }
        }
    }
}
