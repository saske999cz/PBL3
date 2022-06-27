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
        private readonly string accountUsername;
        private readonly string password;
        private string beforeNameAuthor = "";
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        //Constructor
        public FormAddSach(string accountUsername, string password)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
            this.password = password;
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }
        private void FormAddSach_Load(object sender, EventArgs e)
        {
            ShowAllLanguages();
            ShowAllPublishers();
            ShowAllGenres();
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            bool isPublishDateContainsAlpha, isValidFormatPublishDate, isPublishDateGreaterThanCurrentDate = false,
                isValidIDBook, isValidNameBook, isValidLanguage, isValidAuthor, isValidPublisher, 
                isValidGenre, isValidPrice, isValidQuantity, isValidUnit;
            string ID_Book, nameBook, publishDate, author, price, quantity, unit;
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
                msgValidateLanguage.ForeColor = Color.Red;
                msgValidateLanguage.Text = "Ngôn ngữ không được để trống";
                isValidLanguage = false;
            }
            else
            {
                msgValidateLanguage.ForeColor = Color.White;
                msgValidateLanguage.Text = "";
                isValidLanguage = true;
            }
            // Validate author
            author = tbAuthor.Text;
            if (author == "")
            {
                msgValidateAuthor.ForeColor = Color.Red;
                msgValidateAuthor.Text = "Tác giả không được để trống";
                isValidAuthor = false;
            }
            else
            {
                msgValidateAuthor.ForeColor = Color.White;
                msgValidateAuthor.Text = "";
                isValidAuthor = true;
            }
            // Validate publisher
            if (cbbPublisher.SelectedItem == null)
            {
                msgValidatePublisher.ForeColor = Color.Red;
                msgValidatePublisher.Text = "Nhà xuất bản không được để trống";
                isValidPublisher = false;
            }
            else
            {
                msgValidatePublisher.ForeColor = Color.White;
                msgValidatePublisher.Text = "";
                isValidPublisher = true;
            }
            // Validate genre
            if (cbbGenre.SelectedItem == null)
            {
                msgValidateGenre.ForeColor = Color.Red;
                msgValidateGenre.Text = "Thể loại không được để trống";
                isValidGenre = false;
            }
            else
            {
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
            if (cbbUnit.SelectedItem == null)
            {
                unit = "";
                msgValidateUnit.ForeColor = Color.Red;
                msgValidateUnit.Text = "Đơn vị không được để trống";
                isValidUnit = false;
            }
            else
            {
                unit = cbbUnit.SelectedItem.ToString();
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

                    //var findingAuthor = context.Authors
                    //    .Where(auth => auth.FullNameAuthor == tbAuthor.Text)
                    //    .Select(auth => new { auth.ID_Author })
                    //    .ToList()
                    //    .FirstOrDefault();
                    //if (findingAuthor == null)
                    //{
                    //    DialogResult result = RJMessageBox.Show("Tác giả " + tbAuthor.Text + " chưa có trong hệ thống. Xác nhận thêm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //    if (result == DialogResult.Yes)
                    //    {
                    //        new FormIdentify(accountUsername, password, ID_Book, tbAuthor.Text).ShowDialog();

                    //        var newAuthor = context.Authors
                    //            .Where(auth => auth.FullNameAuthor == tbAuthor.Text)
                    //            .Select(auth => new { auth.ID_Author })
                    //            .ToList()
                    //            .LastOrDefault();
                    //        if (newAuthor == null)
                    //        {
                    //            return;
                    //        }
                    //        else
                    //        {
                    //            Book newBook = new Book(ID_Book, nameBook, dateOfPublish, Convert.ToInt32(quantity), Convert.ToInt32(price), unit,
                    //                                            cbbLanguage.SelectedIndex + 1, newAuthor.ID_Author, cbbPublisher.SelectedIndex + 1,
                    //                                            cbbGenre.SelectedIndex + 1, bookImage);
                    //            context.Books.Add(newBook);
                    //            context.SaveChanges();
                    //            RefreshData(sender, e);
                    //            Alert("Thêm sách mới thành công", Form_Alert.EnmType.Success);
                    //            Close();
                    //        }                            
                    //    }
                    //    else
                    //        return;
                    //}
                    //else
                    //{
                    //    Book newBook = new Book(ID_Book, nameBook, dateOfPublish, Convert.ToInt32(quantity), Convert.ToInt32(price), unit,
                    //        cbbLanguage.SelectedIndex + 1, findingAuthor.ID_Author, cbbPublisher.SelectedIndex + 1, cbbGenre.SelectedIndex + 1, bookImage);
                    //    context.Books.Add(newBook);
                    //    context.SaveChanges();
                    //    RefreshData(sender, e);
                    //    Alert("Thêm sách mới thành công", Form_Alert.EnmType.Success);
                    //    Close();
                    //}
                }
            }
            else
            {
                Alert("Dữ liệu không hợp lệ", Form_Alert.EnmType.Error);
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            string ID_Book, nameBook, publishDate, author, price, quantity;
            ID_Book = tbIDBook.Text;
            nameBook = tbNameBook.Text;
            publishDate = tbPublishDate.Text;
            author = tbAuthor.Text;
            price = tbPrice.Text;
            quantity = tbQuantity.Text;
            if (ID_Book != "" || nameBook != "" || publishDate != "" || cbbLanguage.SelectedItem != null || author != ""
                || cbbPublisher.SelectedItem != null || cbbGenre.SelectedItem != null || price != "" || quantity != "0" 
                || cbbUnit.SelectedItem != null || gpbBookImg.Image != null)
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

        private void TbAuthor_TextChanged(object sender, EventArgs e)
        {
            if (beforeNameAuthor.Length > tbAuthor.Text.Length && beforeNameAuthor != "")
            {
                beforeNameAuthor = tbAuthor.Text;
            }
            else
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    if (tbAuthor.Text == "")
                    {
                        return;
                    }
                    else
                    {
                        //var author = context.Authors
                        //.Where(auth => auth.FullNameAuthor.Contains(tbAuthor.Text))
                        //.Select(auth => new { auth.FullNameAuthor })
                        //.ToList()
                        //.FirstOrDefault();
                        //if (author != null)
                        //{
                        //    tbAuthor.Text = author.FullNameAuthor;
                        //}
                        //else
                        //{
                        //    beforeNameAuthor = tbAuthor.Text;
                        //}
                    }
                }
            }
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

        private void BtnBookImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh",
                Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                gpbBookImg.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnDeleteImg_Click(object sender, EventArgs e)
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
                var listLanguages = context.Languages
                    .OrderBy(lang => lang.ID_Language)
                    .Select(lang => lang)
                    .ToList();

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

        private void ShowAllPublishers()
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listPublishers = context.Publishers
                    .OrderBy(publisher => publisher.ID_Publisher)
                    .Select(publisher => publisher)
                    .ToList();

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
                var listGenres = context.Genres
                    .OrderBy(genre => genre.ID_Genre)
                    .Select(genre => genre)
                    .ToList();

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

        private void TbNameNV_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}
