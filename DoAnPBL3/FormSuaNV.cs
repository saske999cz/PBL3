using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormSuaNV : Form
    {
        private readonly string ID_Employee;

        //Constructor
        public FormSuaNV(string ID_Employee)
        {
            InitializeComponent();
            this.ID_Employee = ID_Employee;
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormSuaNV_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var employee = context.Employees
                    .Where(em => em.ID_Employee == ID_Employee)
                    .ToList()
                    .FirstOrDefault();
                tbNameNV.Text = employee.FullNameEmployee;
                tbEmailNV.Text = employee.Email;
                tbBD.Text = employee.DateOfBirth.ToString("dd/MM/yyyy");
                tbStartDate.Text = employee.StartDate.ToString("dd/MM/yyyy");
                cbGenderNV.SelectedItem = employee.Gender;
                tbSDTNV.Text = employee.Phone;
                tbCMNDNV.Text = employee.Id_Card;
                tbAddressNV.Text = employee.Address;
                if (employee.Avatar != null)
                {
                    MemoryStream memoryStream = new MemoryStream(employee.Avatar);
                    avatar.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    avatar.Image = null;
                }
            }
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            bool isDateOfBirthContainsAlpha, isValidFormatDateOfBirth, isValidAge = false, isDateOfBirthGreaterThanCurrentDate,
                isStartDateContainsAlpha, isValidFormatStartDate, isStartDateGreaterThanCurrentDate = false,
                isValidName, isValidEmail, isValidGender, isValidPhone, isValidIdCard, isValidAddress;
            string name, email, dateOfBirth, startDate, gender, phone, idCard, address;
            byte[] ava;
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

                // Validatge date of birth contains alphabet
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

                            // Validate curent date
                            isDateOfBirthGreaterThanCurrentDate = Validators.IsValidDate(dateOfBirth, Validators.DATE_TIME_REGEX);
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

            if (isValidName && isValidEmail && isValidAge && isStartDateGreaterThanCurrentDate
                && isValidGender && isValidIdCard && isValidPhone && isValidAddress)
            {
                DialogResult result = RJMessageBox.Show("Xác nhận lưu mới dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
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
                        Employee employee = context.Employees.Find(ID_Employee);
                        employee.FullNameEmployee = name;
                        employee.Email = email;
                        employee.DateOfBirth = birthday;
                        employee.Gender = gender;
                        employee.Phone = phone;
                        employee.Id_Card = idCard;
                        employee.Address = address;
                        employee.Avatar = ava;
                        // Update to DB
                        context.SaveChanges();
                        Alert("Thay đổi thông tin nhân viên thành công", Form_Alert.EnmType.Success);
                        Close();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                Alert("Dữ liệu không hợp lệ", Form_Alert.EnmType.Error);
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            bool isNewName, isNewEmail, isNewDateOfBirth, isNewStartDate, isNewGender, 
                    isNewPhone, isNewID_Card, isNewAddress, isNewAvatar;
            using (BookStoreContext context = new BookStoreContext())
            {
                var employee = context.Employees
                    .Where(em => em.ID_Employee == ID_Employee)
                    .ToList()
                    .First();
                isNewName = tbNameNV.Text != employee.FullNameEmployee;
                isNewEmail = tbEmailNV.Text != employee.Email;
                isNewDateOfBirth = tbBD.Text != employee.DateOfBirth.ToString("dd/MM/yyyy");
                isNewStartDate = tbStartDate.Text != employee.StartDate.ToString("dd/MM/yyyy");
                isNewGender = cbGenderNV.SelectedItem.ToString() != employee.Gender;
                isNewPhone = tbSDTNV.Text != employee.Phone;
                isNewID_Card = tbCMNDNV.Text != employee.Id_Card;
                isNewAddress = tbAddressNV.Text != employee.Address;
                if (employee.Avatar != null)
                {
                    if (avatar.Image == null)
                    {
                        isNewAvatar = true;
                    }
                    else
                    {
                        if (avatar.ImageLocation != null)
                        {
                            isNewAvatar = true;
                        }
                        else
                        {
                            isNewAvatar = false;
                        }
                    }
                }
                else
                {
                    if (avatar.Image != null)
                    {
                        isNewAvatar = true;
                    }
                    else
                    {
                        isNewAvatar = false;
                    }
                }
                if (isNewName || isNewEmail || isNewDateOfBirth || isNewStartDate || isNewGender
                    || isNewPhone || isNewID_Card || isNewAddress || isNewAvatar)
                {
                    DialogResult result = RJMessageBox.Show("Thông tin cũ đã thay đổi nhưng chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                        Close();
                    else
                        return;
                }
                else
                    Close();
            }
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
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

        private void BtnNVImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnDeleteImg_Click(object sender, EventArgs e)
        {
            avatar.Image = null;
        }

        private void TbNameNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbAddressNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}
