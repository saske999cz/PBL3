using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DoAnPBL3
{
    public partial class FormAddNV : Form
    {
        //Fields
        private int borderRadius = 16;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);
        //Constructor
        public FormAddNV()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitleBar.BackColor = borderColor;
            this.BackColor = borderColor;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }



        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }


        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }


        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();

            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);

            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }


        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }


        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjbtnOK_Click(object sender, EventArgs e)
        {
            bool isValidName, isValidAge, isValidDateOfBirth, isValidEmail, isValidPhone, isValidIdCard;
            string name, gender, idCard, address, phone, email;
            DateTime birthday;
            byte[] ava;
            // Validate name
            name = rjtbNameNV.Texts;
            isValidName = EmployeeValidator.IsValidName(name, EmployeeValidator.NAME_REGEX);
            if (name == "")
            {
                msgName.ForeColor = Color.Red;
                msgName.Text = "Trường này không được để trống";
            }
            else
            {
                if (!isValidName)
                {
                    msgName.ForeColor = Color.Red;
                    msgName.Text = "Họ và tên không hợp lệ";
                }
                else
                {
                    msgName.ForeColor = Color.Black;
                    msgName.Text = "";
                }
            }
            // Validate age
            birthday = gunaDTP.Value;
            isValidAge = EmployeeValidator.IsValidAge(birthday, EmployeeValidator.DATE_TIME_REGEX);
            if (isValidAge)
            {
                msgAge.ForeColor = Color.Black;
                msgAge.Text = "";
            } 
            else
            {
                msgAge.ForeColor = Color.Red;
                msgAge.Text = "Nhân viên ít nhất phải đủ 18 tuổi";
            }
            // Validate date of birth
            isValidDateOfBirth = EmployeeValidator.IsValidDateOfBirth(birthday, EmployeeValidator.DATE_TIME_REGEX);
            if (isValidDateOfBirth)
            {
                msgDateOfBirth.ForeColor = Color.Black;
                msgDateOfBirth.Text = "";
            }
            else
            {
                msgDateOfBirth.ForeColor = Color.Red;
                msgDateOfBirth.Text = "Ngày sinh không được lớn hơn ngày hiện tại";
            }
            // Validate gender
            if (rjcbbGender.SelectedItem == null)
            {
                gender = "";
                msgGender.ForeColor = Color.Red;
                msgGender.Text = "Trường này không được để trống";
            } 
            else
            {
                gender = rjcbbGender.SelectedItem.ToString();
                msgGender.ForeColor = Color.Black;
                msgGender.Text = "";
            }
            // Validate email
            email = rjtbEmail.Texts;
            isValidEmail = EmployeeValidator.IsValidEmail(email);
            if (email == "")
            {
                msgEmail.ForeColor = Color.Red;
                msgEmail.Text = "Trường này không được để trống";
            }
            else
            {
                if (!isValidEmail)
                {
                    msgEmail.ForeColor = Color.Red;
                    msgEmail.Text = "Email không hợp lệ";
                }
                else
                {
                    msgEmail.ForeColor = Color.Black;
                    msgEmail.Text = "";
                }
            }
            // Validate phone number
            phone = rjtbSDT.Texts;
            isValidPhone = EmployeeValidator.IsValidPhoneNumber(phone, EmployeeValidator.PHONE_REGEX);
            if (phone == "")
            {
                msgPhone.ForeColor = Color.Red;
                msgPhone.Text = "Trường này không được để trống";
            } 
            else
            {
                if (!isValidPhone)
                {
                    msgPhone.ForeColor = Color.Red;
                    msgPhone.Text = "SĐT không hợp lệ";
                }
                else
                {
                    msgPhone.ForeColor = Color.Black;
                    msgPhone.Text = "";
                }
            }
            // Validate ID Card
            idCard = rjtbCMND.Texts;
            isValidIdCard = EmployeeValidator.IsValidIdCard(idCard, EmployeeValidator.ID_CARD_REGEX);
            if (idCard == "")
            {
                msgIDCard.ForeColor = Color.Red;
                msgIDCard.Text = "Trường này không được để trống";
            }
            else
            {
                if (!isValidIdCard)
                {
                    msgIDCard.ForeColor = Color.Red;
                    msgIDCard.Text = "CMND không hợp lệ";
                }
                else
                {
                    msgIDCard.ForeColor = Color.Black;
                    msgIDCard.Text = "";
                }
            }
            // Validate address
            if (rjcbbAddress.SelectedItem == null)
            {
                address = "";
                msgAddress.ForeColor = Color.Red;
                msgAddress.Text = "Trường này không được để trống";
            }
            else
            {
                address = rjcbbAddress.SelectedItem.ToString();
                msgAddress.ForeColor = Color.Black;
                msgAddress.Text = "";
            }
            // Validate image
            if (avatar.Image == null)
            {
                ava = null;
            }
            else
            {
                ava = ImageToByteArray(avatar);
            }
            
            if (isValidName && isValidEmail && isValidIdCard && isValidPhone)
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    var listID = context.Employees
                                    .OrderBy(em => em.ID_Employee)
                                    .Select(em => em.ID_Employee);
                    String id = listID.ToList().Last(); // E0006
                    String code = id.Substring(1, id.Length - 1); // 0006
                    int num = Convert.ToInt32(code); // 6
                    num++; // 6 + 1 -> 7
                    string numStr = num.ToString(); // "7"
                    int lenNumStr = numStr.Length; // 1
                    StringBuilder newEmployeeId = new StringBuilder(id); // E0006
                    newEmployeeId = newEmployeeId.Remove(newEmployeeId.Length - lenNumStr, lenNumStr);// E000
                    newEmployeeId.Append(numStr); // E000 + 7 => E0007
                    Employee employee = new Employee(newEmployeeId.ToString(), name, email, birthday, gender, phone, idCard, address, ava, null);
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    Console.WriteLine(name);
                    char[] c = name.ToCharArray();
                    foreach(char item in c)
                    {
                        Console.WriteLine(item);
                    }
                    Alert("Thêm nhân viên mới thành công", Form_Alert.enmType.Success);
                    Close();
                }
            } 
            else
            { 
                this.Alert("Dữ liệu không hợp lệ", Form_Alert.enmType.Error);
            }
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }
    }
}
