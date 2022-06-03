using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;
using DoAnPBL3.Properties;

namespace DoAnPBL3
{
    public partial class FormAddNV : Form
    {
        //Constructor
        public FormAddNV()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void rjbtnOK_Click(object sender, EventArgs e)
        {
            bool isDateOfBirthContainsAlpha, isValidFormatDateOfBirth, isValidAge = false, isDateOfBirthGreaterThanCurrentDate, 
                isStartDateContainsAlpha, isValidFormatStartDate, isStartDateGreaterThanCurrentDate = false,
                isValidID, isValidName, isValidEmail, isValidGender, isValidPhone, isValidIdCard, isValidAddress;
            string id, name, email, dateOfBirth, startDate, gender, phone, idCard, address, username, password;
            byte[] ava;
            // Validate id employee
            id = tbIDNV.Text;
            if (id == "")
            {
                msgValidateID.ForeColor = Color.Red;
                msgValidateID.Text = "Mã nhân viên không được để trống";
                isValidID = false;
            }
            else
            {
                if (Validators.IsExistID_Employee(id))
                {
                    msgValidateID.ForeColor = Color.Red;
                    msgValidateID.Text = "Mã nhân viên đã tồn tại";
                    isValidID = false;
                }
                else
                {
                    msgValidateID.ForeColor = Color.White;
                    msgValidateID.Text = "";
                    isValidID = true;
                }
            }
            // Validate name
            name = tbNameNV.Text;
            if (name == "")
            {
                msgValidateName.ForeColor = Color.Red;
                msgValidateName.Text = "Họ và tên nhân viên không được để trống";
                isValidName = false;
            }
            else
            {
                msgValidateName.ForeColor = Color.White;
                msgValidateName.Text = "";
                isValidName = true;
            }
            // Validate email
            email = tbEmailNV.Text;
            isValidEmail = Validators.IsValidEmail(email);
            if (email == "")
            {
                msgValidateEmail.ForeColor = Color.Red;
                msgValidateEmail.Text = "Email không được để trống";
            }
            else
            {
                if (!isValidEmail)
                {
                    msgValidateEmail.ForeColor = Color.Red;
                    msgValidateEmail.Text = "Email không hợp lệ";
                }
                else
                {
                    msgValidateEmail.ForeColor = Color.White;
                    msgValidateEmail.Text = "";
                }
            }
            // Validate value of input date of birth
            dateOfBirth = tbBD.Text;
            if (dateOfBirth == "")
            {
                msgValidateDateOfBirth.ForeColor = Color.Red;
                msgValidateDateOfBirth.Text = "Ngày sinh không được để trống";
            }
            else
            {
                msgValidateDateOfBirth.ForeColor = Color.White;
                msgValidateDateOfBirth.Text = "";

                // Validate date of birth contains alphabet
                isDateOfBirthContainsAlpha = Validators.IsDateContainsAlphabet(dateOfBirth);
                if (isDateOfBirthContainsAlpha)
                {
                    msgValidateDateOfBirth.ForeColor = Color.Red;
                    msgValidateDateOfBirth.Text = "Ngày sinh không hợp lệ";
                }
                else
                {
                    msgValidateDateOfBirth.ForeColor = Color.White;
                    msgValidateDateOfBirth.Text = "";

                    // Validate format date of birth
                    isValidFormatDateOfBirth = Validators.IsValidFormatDate(dateOfBirth, Validators.DATE_TIME_REGEX);
                    if (!isValidFormatDateOfBirth)
                    {
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        msgValidateDateOfBirth.Text = "Ngày sinh phải theo định dạng dd/MM/yyyy";
                    }
                    else
                    {
                        // Check date of birth
                        string msgValidate = Validators.CheckDate(dateOfBirth, Validators.DATE_TIME_REGEX);
                        if (msgValidate != "")
                        {
                            msgValidateDateOfBirth.ForeColor = Color.Red;
                            msgValidateDateOfBirth.Text = msgValidate;
                        }
                        else
                        {
                            msgValidateDateOfBirth.ForeColor = Color.White;
                            msgValidateDateOfBirth.Text = "";

                            // Validate current date
                            isDateOfBirthGreaterThanCurrentDate = Validators.IsValidDate(dateOfBirth, Validator.Validators.DATE_TIME_REGEX);
                            if (!isDateOfBirthGreaterThanCurrentDate)
                            {
                                msgValidateDateOfBirth.ForeColor = Color.Red;
                                msgValidateDateOfBirth.Text = "Ngày sinh không được lớn hơn ngày hiện tại";
                            }
                            else
                            {
                                msgValidateDateOfBirth.ForeColor = Color.White;
                                msgValidateDateOfBirth.Text = "";

                                // Validate age
                                isValidAge = Validators.IsValidAge(dateOfBirth, Validators.DATE_TIME_REGEX);
                                if (!isValidAge)
                                {
                                    msgValidateDateOfBirth.ForeColor = Color.Red;
                                    msgValidateDateOfBirth.Text = "Nhân viên ít nhất phải đủ 18 tuổi";
                                    isValidAge = false;
                                }
                                else
                                {
                                    msgValidateDateOfBirth.ForeColor = Color.White;
                                    msgValidateDateOfBirth.Text = "";
                                    isValidAge = true;
                                }
                            }
                        }
                    }
                }
            }

            // Validate value of input start date
            startDate = tbStartDate.Text;
            if (startDate == "")
            {
                msgValidateStartDate.ForeColor = Color.Red;
                msgValidateStartDate.Text = "Ngày bắt đầu làm việc không được để trống";
            }
            else
            {
                msgValidateStartDate.ForeColor = Color.White;
                msgValidateStartDate.Text = "";

                // Validatge start date contains alphabet
                isStartDateContainsAlpha = Validators.IsDateContainsAlphabet(dateOfBirth);
                if (isStartDateContainsAlpha)
                {
                    msgValidateStartDate.ForeColor = Color.Red;
                    msgValidateStartDate.Text = "Ngày bắt đầu làm việc không hợp lệ";
                }
                else
                {
                    msgValidateStartDate.ForeColor = Color.White;
                    msgValidateStartDate.Text = "";

                    // Validate format start date
                    isValidFormatStartDate = Validators.IsValidFormatDate(dateOfBirth, Validators.DATE_TIME_REGEX);
                    if (!isValidFormatStartDate)
                    {
                        msgValidateStartDate.ForeColor = Color.Red;
                        msgValidateStartDate.Text = "Ngày bắt đầu làm việc phải theo định dạng dd/MM/yyyy";
                    }
                    else
                    {
                        // Check start date
                        string msgValidate = Validators.CheckDate(dateOfBirth, Validators.DATE_TIME_REGEX);
                        if (msgValidate != "")
                        {
                            msgValidateStartDate.ForeColor = Color.Red;
                            msgValidateStartDate.Text = msgValidate;
                        }
                        else
                        {
                            msgValidateStartDate.ForeColor = Color.White;
                            msgValidateStartDate.Text = "";

                            // Validate curent date
                            isStartDateGreaterThanCurrentDate = Validators.IsValidDate(dateOfBirth, Validators.DATE_TIME_REGEX);
                            if (!isStartDateGreaterThanCurrentDate)
                            {
                                msgValidateStartDate.ForeColor = Color.Red;
                                msgValidateStartDate.Text = "Ngày bắt đầu làm việc không được lớn hơn ngày hiện tại";
                                isStartDateGreaterThanCurrentDate = false;
                            }
                            else
                            {
                                msgValidateStartDate.ForeColor = Color.White;
                                msgValidateStartDate.Text = "";
                                isStartDateGreaterThanCurrentDate = true;
                            }
                        }
                    }
                }
            }
            // Validate gender
            if (cbGenderNV.SelectedItem == null)
            {
                gender = "";
                msgValidateGender.ForeColor = Color.Red;
                msgValidateGender.Text = "Giới tính không được để trống";
                isValidGender = false;
            }
            else
            {
                gender = cbGenderNV.SelectedItem.ToString();
                msgValidateGender.ForeColor = Color.White;
                msgValidateGender.Text = "";
                isValidGender = true;
            }
            // Validate phone number
            phone = tbSDTNV.Text;
            isValidPhone = Validators.IsValidPhoneNumber(phone, Validators.PHONE_REGEX);
            if (phone == "")
            {
                msgValidatePhone.ForeColor = Color.Red;
                msgValidatePhone.Text = "SĐT nhân viên không được để trống";
            }
            else
            {
                if (!isValidPhone)
                {
                    msgValidatePhone.ForeColor = Color.Red;
                    msgValidatePhone.Text = "SĐT không hợp lệ";
                }
                else
                {
                    msgValidatePhone.ForeColor = Color.White;
                    msgValidatePhone.Text = "";
                }
            }
            // Validate ID Card
            idCard = tbCMNDNV.Text;
            isValidIdCard = Validators.IsValidIdCard(idCard, Validators.ID_CARD_REGEX);
            if (idCard == "")
            {
                msgValidateIDCard.ForeColor = Color.Red;
                msgValidateIDCard.Text = "CMND không được để trống";
            }
            else
            {
                if (!isValidIdCard)
                {
                    msgValidateIDCard.ForeColor = Color.Red;
                    msgValidateIDCard.Text = "CMND không hợp lệ";
                }
                else
                {
                    msgValidateIDCard.ForeColor = Color.White;
                    msgValidateIDCard.Text = "";
                }
            }
            // Validate address
            if (tbAddressNV.Text == "")
            {
                address = "";
                msgValidateAddress.ForeColor = Color.Red;
                msgValidateAddress.Text = "Địa chỉ không được để trống";
                isValidAddress = false;
            }
            else
            {
                address = tbAddressNV.Text;
                msgValidateAddress.ForeColor = Color.White;
                msgValidateAddress.Text = "";
                isValidAddress = true;
            }
            // Validate image
            if (avatar.ImageLocation == "" || avatar.ImageLocation == null)
            {
                ava = null;
            }
            else
            {
                try
                {
                    ava = ImageToByteArray(avatar);
                }
                catch (ExternalException)
                {
                    return;
                }
            }

            if (isValidID && isValidName && isValidEmail && isValidAge && isStartDateGreaterThanCurrentDate
                && isValidGender && isValidIdCard && isValidPhone && isValidAddress)
            {
                using (BookStoreContext context = new BookStoreContext())
                {    
                    DateTime birthday = new DateTime(
                        Convert.ToInt32(dateOfBirth.Substring(6, 4)),
                        Convert.ToInt32(dateOfBirth.Substring(3, 2)),
                        Convert.ToInt32(dateOfBirth.Substring(0, 2))
                    );
                    DateTime startDateTime = new DateTime(
                        Convert.ToInt32(startDate.Substring(6, 4)),
                        Convert.ToInt32(startDate.Substring(3, 2)),
                        Convert.ToInt32(startDate.Substring(0, 2))
                    );

                    username = ReplaceWhiteSpace(name.ToLower());
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in username)
                    {
                        sb.Append(ConvertVietnameseToAlphabet(c));
                    }
                    foreach (char c in id)
                    {
                        sb.Append(c);
                    }
                    username = sb.ToString();
                    password = sb.ToString();

                    ImageConverter imageConverter = new ImageConverter();

                    if (gender == "Nam")
                    {
                        Account newAccount = new Account(username, password, email, false, 
                            (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[])));
                        context.Accounts.Add(newAccount);
                        context.SaveChanges();
                    }
                    else
                    {
                        Account newAccount = new Account(username, password, email, false,
                            (byte[])imageConverter.ConvertTo(Resources.female_employee, typeof(byte[])));
                        context.Accounts.Add(newAccount);
                        context.SaveChanges();
                    }

                    Employee newEmployee = new Employee(id, name, email, birthday, startDateTime,
                        gender, phone, idCard, address, ava, username);
                    context.Employees.Add(newEmployee);
                    context.SaveChanges();
                    Alert("Thêm nhân viên mới thành công", Form_Alert.enmType.Success);
                    Close();
                }
            }
            else
            {
                Alert("Dữ liệu không hợp lệ", Form_Alert.enmType.Error);
            }
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            string id, name, email, dateOfBirth, startDate, phone, idCard, address;
            id = tbIDNV.Text;
            name = tbNameNV.Text;
            email = tbEmailNV.Text;
            dateOfBirth = tbBD.Text;
            startDate = tbStartDate.Text;
            phone = tbSDTNV.Text;
            idCard = tbCMNDNV.Text;
            address = tbAddressNV.Text;
            if (id != "" || name != "" || email != "" || dateOfBirth != "" || startDate != "" 
                || cbGenderNV.SelectedItem != null || phone != "" || idCard != "" || address != "" || avatar.Image != null)
            {
                DialogResult result = RJMessageBox.Show("Dữ liệu chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Close();
                else
                    return;
            }
            else
                Close();
        }

        private byte[] ImageToByteArray(Guna2PictureBox pictureBox)
        {
            using (Bitmap bitmap = new Bitmap(avatar.ImageLocation))
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

        private void btnNVImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            if (avatar.ImageLocation != null)
            {
                avatar.ImageLocation = "";
                avatar.Image = null;
            }
        }

        private char ConvertVietnameseToAlphabet(char alphaName)
        {
            if (alphaName == 'á' || alphaName == 'Á' || alphaName == 'à' || alphaName == 'À' || alphaName == 'ả' || alphaName == 'Ả'
                || alphaName == 'ã' || alphaName == 'Ã' || alphaName == 'ạ' || alphaName == 'Ạ' || alphaName == 'ă' || alphaName == 'Ă'
                || alphaName == 'ắ' || alphaName == 'Ắ' || alphaName == 'ằ' || alphaName == 'Ằ' || alphaName == 'ẳ' || alphaName == 'Ẳ'
                || alphaName == 'ẵ' || alphaName == 'Ẵ' || alphaName == 'ặ' || alphaName == 'Ặ' || alphaName == 'â' || alphaName == 'Â'
                || alphaName == 'ấ' || alphaName == 'Ấ' || alphaName == 'ầ' || alphaName == 'Ầ' || alphaName == 'ẩ' || alphaName == 'Ẩ'
                || alphaName == 'ẫ' || alphaName == 'Ẫ' || alphaName == 'ậ' || alphaName == 'Ậ')
                return 'a';
            else if (alphaName == 'đ' || alphaName == 'Đ')
                return 'd';
            else if (alphaName == 'é' || alphaName == 'É' || alphaName == 'è' || alphaName == 'È' || alphaName == 'ẻ' || alphaName == 'Ẻ'
                || alphaName == 'ẽ' || alphaName == 'Ẽ' || alphaName == 'ẹ' || alphaName == 'Ẹ' || alphaName == 'ê' || alphaName == 'Ê'
                || alphaName == 'ế' || alphaName == 'Ế' || alphaName == 'ề' || alphaName == 'Ề' || alphaName == 'ể' || alphaName == 'Ể'
                || alphaName == 'ể' || alphaName == 'Ể' || alphaName == 'ệ' || alphaName == 'Ệ')
                return 'e';
            else if (alphaName == 'í' || alphaName == 'Í' || alphaName == 'ì' || alphaName == 'Ì' || alphaName == 'ỉ' || alphaName == 'Ỉ'
                || alphaName == 'ĩ' || alphaName == 'Ĩ' || alphaName == 'ị' || alphaName == 'Ị')
                return 'i';
            else if (alphaName == 'ó' || alphaName == 'Ó' || alphaName == 'ò' || alphaName == 'Ò' || alphaName == 'ỏ' || alphaName == 'Ỏ'
                || alphaName == 'õ' || alphaName == 'Õ' || alphaName == 'ọ' || alphaName == 'Ọ' || alphaName == 'ô' || alphaName == 'Ô'
                || alphaName == 'ố' || alphaName == 'Ố' || alphaName == 'ồ' || alphaName == 'Ồ' || alphaName == 'ổ' || alphaName == 'Ổ'
                || alphaName == 'ỗ' || alphaName == 'Ỗ' || alphaName == 'ộ' || alphaName == 'Ộ' || alphaName == 'ơ' || alphaName == 'Ơ'
                || alphaName == 'ớ' || alphaName == 'Ớ' || alphaName == 'ờ' || alphaName == 'Ờ' || alphaName == 'ở' || alphaName == 'Ở'
                || alphaName == 'ỡ' || alphaName == 'Ỡ' || alphaName == 'ợ' || alphaName == 'Ợ')
                return 'o';
            else if (alphaName == 'ú' || alphaName == 'Ú' || alphaName == 'ù' || alphaName == 'Ù' || alphaName == 'ủ' || alphaName == 'Ủ'
                || alphaName == 'ũ' || alphaName == 'Ũ' || alphaName == 'ụ' || alphaName == 'Ụ' || alphaName == 'ư' || alphaName == 'Ư'
                || alphaName == 'ứ' || alphaName == 'Ứ' || alphaName == 'ừ' || alphaName == 'Ừ' || alphaName == 'ử' || alphaName == 'Ử'
                || alphaName == 'ữ' || alphaName == 'Ữ' || alphaName == 'ự' || alphaName == 'Ự')
                return 'u';
            else if (alphaName == 'ý' || alphaName == 'Ý' || alphaName == 'ỳ' || alphaName == 'Ỳ' || alphaName == 'ỷ' || alphaName == 'Ỷ'
                || alphaName == 'ỹ' || alphaName == 'Ỹ' || alphaName == 'ỵ' || alphaName == 'Ỵ')
                return 'y';
            else
                return alphaName;
        }

        private static string ReplaceWhiteSpace(string input)
        {
            return new string(input.ToCharArray()
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray());
        }

        private void tbNameNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbAddressNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}