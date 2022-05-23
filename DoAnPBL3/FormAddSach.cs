using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormAddSach : Form
    {
        
        //Constructor
        public FormAddSach()
        {
            InitializeComponent();   
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void FormAddSach_Load(object sender, EventArgs e)
        {
            ShowAllLanguages();
            ShowAllAuthors();
            ShowAllPublishers();
            ShowAllGenres();
        }

        private void rjbtnOK_Click(object sender, EventArgs e)
        {
            bool isPublishDateContainsAlpha, isValidFormatPublishDate, isPublishDateGreaterThanCurrentDate = false,
                isValidIDBook, isValidNameBook, isValidLanguage, isValidAuthor, isValidPublisher, 
                isValidGenre, isValidPrice, isValidQuantity, isValidUnit;
            string ID_Book, nameBook, publishDate, language, author, publisher, genre, price, quantity, unit;
            byte[] bookImage;
            // Validate id book
            ID_Book = tbIDBook.Text;
            if (ID_Book == "")
            {
                msgValidateIDBook.ForeColor = Color.Red;
                msgValidateIDBook.Text = "Mã sách không được để trống";
                isValidIDBook = false;
            }
            else
            {
                if (Validators.IsExistID_Book(ID_Book))
                {
                    msgValidateIDBook.ForeColor = Color.Red;
                    msgValidateIDBook.Text = "Mã sách đã tồn tại";
                    isValidIDBook = false;
                }
                else
                {
                    msgValidateIDBook.ForeColor = Color.White;
                    msgValidateIDBook.Text = "";
                    isValidIDBook = true;
                }
            }
            // Validate name of book
            nameBook = tbNameBook.Text;
            if (nameBook == "")
            {
                msgValidateNameBook.ForeColor = Color.Red;
                msgValidateNameBook.Text = "Tên sách không được để trống";
                isValidNameBook = false;
            }
            else
            {
                msgValidateNameBook.ForeColor = Color.White;
                msgValidateNameBook.Text = "";
                isValidNameBook = true;
            }
            // Validate value of input publish date
            publishDate = tbPublishDate.Text;
            if (publishDate == "")
            {
                msgValidatePublishDate.ForeColor = Color.Red;
                msgValidatePublishDate.Text = "Ngày xuất bản không được để trống";
            }
            else
            {
                msgValidatePublishDate.ForeColor = Color.White;
                msgValidatePublishDate.Text = "";

                // Validatge publish date contains alphabet
                isPublishDateContainsAlpha = Validators.IsDateContainsAlphabet(publishDate);
                if (isPublishDateContainsAlpha)
                {
                    msgValidatePublishDate.ForeColor = Color.Red;
                    msgValidatePublishDate.Text = "Ngày xuất bản không hợp lệ";
                }
                else
                {
                    msgValidatePublishDate.ForeColor = Color.White;
                    msgValidatePublishDate.Text = "";

                    // Validate format publish date
                    isValidFormatPublishDate = Validators.IsValidFormatDate(publishDate, Validators.DATE_TIME_REGEX);
                    if (!isValidFormatPublishDate)
                    {
                        msgValidatePublishDate.ForeColor = Color.Red;
                        msgValidatePublishDate.Text = "Ngày xuất bản phải theo định dạng dd/MM/yyyy";
                    }
                    else
                    {
                        // Check publish date
                        string msgValidate = Validators.CheckDate(publishDate, Validators.DATE_TIME_REGEX);
                        if (msgValidate != "")
                        {
                            msgValidatePublishDate.ForeColor = Color.Red;
                            msgValidatePublishDate.Text = msgValidate;
                        }
                        else
                        {
                            msgValidatePublishDate.ForeColor = Color.White;
                            msgValidatePublishDate.Text = "";

                            // Validate curent date
                            isPublishDateGreaterThanCurrentDate = Validators.IsValidDate(publishDate, Validators.DATE_TIME_REGEX);
                            if (!isPublishDateGreaterThanCurrentDate)
                            {
                                msgValidatePublishDate.ForeColor = Color.Red;
                                msgValidatePublishDate.Text = "Ngày xuất bản không được lớn hơn ngày hiện tại";
                                isPublishDateGreaterThanCurrentDate = false;
                            }
                            else
                            {
                                msgValidatePublishDate.ForeColor = Color.White;
                                msgValidatePublishDate.Text = "";
                                isPublishDateGreaterThanCurrentDate = true;
                            }
                        }
                    }
                }
            }
            // Validate language
            if (cbbLanguage.SelectedItem == null)
            {
                language = "";
                msgValidateLanguage.ForeColor = Color.Red;
                msgValidateLanguage.Text = "Ngôn ngữ không được để trống";
                isValidLanguage = false;
            }
            else
            {
                language = cbbLanguage.SelectedItem.ToString();
                msgValidateLanguage.ForeColor = Color.White;
                msgValidateLanguage.Text = "";
                isValidLanguage = true;
            }
            // Validate author
            if (cbbAuthor.SelectedItem == null)
            {
                author = "";
                msgValidateAuthor.ForeColor = Color.Red;
                msgValidateAuthor.Text = "Tác giả không được để trống";
                isValidAuthor = false;
            }
            else
            {
                author = cbbAuthor.SelectedItem.ToString();
                msgValidateAuthor.ForeColor = Color.White;
                msgValidateAuthor.Text = "";
                isValidAuthor = true;
            }
            // Validate publisher
            if (cbbPublisher.SelectedItem == null)
            {
                publisher = "";
                msgValidatePublisher.ForeColor = Color.Red;
                msgValidatePublisher.Text = "Nhà xuất bản không được để trống";
                isValidPublisher = false;
            }
            else
            {
                publisher = cbbPublisher.SelectedItem.ToString();
                msgValidatePublisher.ForeColor = Color.White;
                msgValidatePublisher.Text = "";
                isValidPublisher = true;
            }
            // Validate genre
            if (cbbGenre.SelectedItem == null)
            {
                genre = "";
                msgValidateGenre.ForeColor = Color.Red;
                msgValidateGenre.Text = "Thể loại không được để trống";
                isValidGenre = false;
            }
            else
            {
                genre = cbbGenre.SelectedItem.ToString();
                msgValidateGenre.ForeColor = Color.White;
                msgValidateGenre.Text = "";
                isValidGenre = true;
            }
            // Validate price
            price = tbPrice.Text;
            if (price == "")
            {
                msgValidatePrice.ForeColor = Color.Red;
                msgValidatePrice.Text = "Giá không được để trống";
                isValidPrice = false;
            }
            else
            {
                msgValidatePrice.ForeColor = Color.White;
                msgValidatePrice.Text = "";
                isValidPrice = true;
            }
            // Validate quantity
            quantity = tbQuantity.Text;
            if (quantity == "")
            {
                msgValidateQuantity.ForeColor = Color.Red;
                msgValidateQuantity.Text = "Số lượng không được để trống";
                isValidQuantity = false;
            }
            else
            {
                if (quantity == "0")
                {
                    msgValidateQuantity.ForeColor = Color.Red;
                    msgValidateQuantity.Text = "Số lượng sách không hợp lệ";
                    isValidQuantity = false;
                }
                else
                {
                    msgValidateQuantity.ForeColor = Color.White;
                    msgValidateQuantity.Text = "";
                    isValidQuantity = true;
                }
            }
            // Validate unit
            if (cbUnit.SelectedItem == null)
            {
                unit = "";
                msgValidateUnit.ForeColor = Color.Red;
                msgValidateUnit.Text = "Đơn vị không được để trống";
                isValidUnit = false;
            }
            else
            {
                unit = cbUnit.SelectedItem.ToString();
                msgValidateUnit.ForeColor = Color.White;
                msgValidateUnit.Text = "";
                isValidUnit = true;
            }

            // Validate image
            if (gpbBookImg.ImageLocation == "" || gpbBookImg.ImageLocation == null)
            {
                bookImage = null;
            }
            else
            {
                try
                {
                    bookImage = ImageToByteArray(gpbBookImg);
                }
                catch (ExternalException)
                {
                    return;
                }
            }

            if (isValidIDBook && isValidNameBook && isPublishDateGreaterThanCurrentDate && isValidLanguage
                && isValidAuthor && isValidPublisher && isValidGenre && isValidPrice && isValidQuantity && isValidUnit)
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    DateTime dateOfPublish = new DateTime(
                        Convert.ToInt32(publishDate.Substring(6, 4)),
                        Convert.ToInt32(publishDate.Substring(3, 2)),
                        Convert.ToInt32(publishDate.Substring(0, 2))
                    );

                    Book newBook = new Book(ID_Book, nameBook, dateOfPublish, Convert.ToInt32(quantity), Convert.ToInt32(price), unit, 
                      cbbLanguage.SelectedIndex + 1, cbbAuthor.SelectedIndex + 1, cbbPublisher.SelectedIndex + 1, cbbGenre.SelectedIndex + 1, bookImage);
                    context.Books.Add(newBook);
                    context.SaveChanges();
                    Alert("Thêm sách mới thành công", Form_Alert.enmType.Success);
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
            string ID_Book, nameBook, publishDate, price, quantity;
            ID_Book = tbIDBook.Text;
            nameBook = tbNameBook.Text;
            publishDate = tbPublishDate.Text;
            price = tbPrice.Text;
            quantity = tbQuantity.Text;
            if (ID_Book != "" || nameBook != "" || publishDate != "" || cbbLanguage.SelectedItem != null 
                || cbbAuthor.SelectedItem != null || cbbPublisher.SelectedItem != null || cbbGenre.SelectedItem != null 
                || price != "" || quantity != "0" || cbUnit.SelectedItem != null || gpbBookImg.Image != null)
            {
                DialogResult result = RJMessageBox.Show("Dữ liệu chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
            using (Bitmap bitmap = new Bitmap(gpbBookImg.ImageLocation))
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
        private void btnBookImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                gpbBookImg.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            if (gpbBookImg.ImageLocation != null)
            {
                gpbBookImg.ImageLocation = "";
                gpbBookImg.Image = null;
            }
        }

        private void ShowAllLanguages()
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listLanguages = context.Languages.OrderBy(lang => lang.ID_Language).Select(lang => lang).ToList();

                int numLanguage = listLanguages.Count();
                if (numLanguage != 0)
                {
                    for (int i = 0; i < numLanguage; i++)
                    {
                        cbbLanguage.Items.Add(listLanguages[i].NameLanguage);
                    }
                }
                else
                {
                    cbbLanguage.Items.Add("");
                }
            }
        }
        private void ShowAllAuthors()
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listAuthors = context.Authors.OrderBy(author => author.ID_Author).Select(author => author).ToList();

                int numAuthor = listAuthors.Count();
                if (numAuthor != 0)
                {
                    for (int i = 0; i < numAuthor; i++)
                    {
                        cbbAuthor.Items.Add(listAuthors[i].FullNameAuthor);
                    }
                }
                else
                {
                    cbbAuthor.Items.Add("");
                }
            }
        }

        private void ShowAllPublishers()
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listPublishers = context.Publishers.OrderBy(publisher => publisher.ID_Publisher).Select(publisher => publisher).ToList();
                int numPublisher = listPublishers.Count();
                if (numPublisher != 0)
                {
                    for (int i = 0; i < numPublisher; i++)
                    {
                        cbbPublisher.Items.Add(listPublishers[i].NamePublisher);
                    }
                }
                else
                {
                    cbbPublisher.Items.Add("");
                }
            }
        }

        private void ShowAllGenres()
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listGenres = context.Genres.OrderBy(genre => genre.ID_Genre).Select(genre => genre).ToList();
                int numGenre = listGenres.Count();
                if (numGenre != 0)
                {
                    for (int i = 0; i < numGenre; i++)
                    {
                        cbbGenre.Items.Add(listGenres[i].NameGenre);
                    }
                }
                else
                {
                    cbbGenre.Items.Add("");
                }
            }
        }

        //private List<CBBAuthor> 

        private void tbNameNV_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}
