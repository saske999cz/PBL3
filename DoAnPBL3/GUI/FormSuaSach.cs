using DoAnPBL3.Models;
using DoAnPBL3.Validator;
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
    public partial class FormSuaSach : Form
    {
        private readonly string ID_Book;
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        public FormSuaSach(string ID_Book)
        {
            InitializeComponent();
            this.ID_Book = ID_Book;
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormSuaSach_Load(object sender, EventArgs e)
        {
            ShowAllLanguages();
            ShowAllPublishers();
            ShowAllGenres();
            using (BookStoreContext context = new BookStoreContext())
            {
                var book = context.Books
                        .Join(
                            context.Languages,
                            b => b.ID_Language,
                            lang => lang.ID_Language,
                            (b, lang) => new
                            {
                                b.ID_Book,
                                b.NameBook,
                                b.PublishDate,
                                b.Price,
                                b.Quantity,
                                b.Unit,
                                b.Image,
                                b.ID_Publisher,
                                b.ID_Genre,
                                lang.NameLanguage
                            })
                        .Join(
                            context.Genres,
                            b => b.ID_Genre,
                            genre => genre.ID_Genre,
                            (b, genre) => new
                            {
                                b.ID_Book,
                                b.NameBook,
                                b.PublishDate,
                                b.Price,
                                b.Quantity,
                                b.Unit,
                                b.Image,
                                b.ID_Publisher,
                                b.ID_Genre,
                                b.NameLanguage,
                                genre.NameGenre,
                            })
                        .Join(
                            context.Publishers,
                            b => b.ID_Publisher,
                            publisher => publisher.ID_Publisher,
                            (b, publisher) => new
                            {
                                b.ID_Book,
                                b.NameBook,
                                b.PublishDate,
                                b.Price,
                                b.Quantity,
                                b.Unit,
                                b.Image,
                                b.NameLanguage,
                                b.NameGenre,
                                publisher.NamePublisher
                            })
                        .Where(b => b.ID_Book == ID_Book)
                        .Select(b => b)
                        .ToList()
                        .FirstOrDefault();
                tbNameBook.Text = book.NameBook;
                tbPublishDate.Text = book.PublishDate.ToString("dd/MM/yyyy");
                //tbAuthor.Text = book.FullNameAuthor;
                cbbLanguage.Texts = book.NameLanguage;
                cbbPublisher.Texts = book.NamePublisher;
                cbbGenre.Texts = book.NameGenre;
                tbPrice.Text = book.Price.ToString();
                tbQuantity.Text = book.Quantity.ToString();
                cbbUnit.Texts = book.Unit;
            }
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            bool isPublishDateContainsAlpha, isValidFormatPublishDate, isPublishDateGreaterThanCurrentDate = false,
                isValidNameBook, isValidLanguage, isValidAuthor, isValidPublisher, isValidGenre, isValidPrice,
                isValidQuantity, isValidUnit;
            string nameBook, publishDate, author, price, quantity;
            byte[] bookImage;
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
                msgValidateUnit.ForeColor = Color.Red;
                msgValidateUnit.Text = "Đơn vị không được để trống";
                isValidUnit = false;
            }
            else
            {
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

            if (isValidNameBook && isPublishDateGreaterThanCurrentDate && isValidLanguage && isValidAuthor
                && isValidPublisher && isValidGenre && isValidPrice && isValidQuantity && isValidUnit)
            {
                DialogResult result = RJMessageBox.Show("Xác nhận lưu mới dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        DateTime dateOfPublish = new DateTime(
                            Convert.ToInt32(publishDate.Substring(6, 4)),
                            Convert.ToInt32(publishDate.Substring(3, 2)),
                            Convert.ToInt32(publishDate.Substring(0, 2))
                        );

                        Book book = context.Books.Find(ID_Book);
                        book.NameBook = nameBook;
                        book.PublishDate = dateOfPublish;
                        book.ID_Language = cbbLanguage.SelectedIndex + 1;
                        book.ID_Publisher = cbbPublisher.SelectedIndex + 1;
                        book.ID_Genre = cbbGenre.SelectedIndex + 1;
                        book.Quantity = Convert.ToInt32(quantity);
                        book.Price = Convert.ToInt32(price);
                        book.Unit = cbbUnit.SelectedItem.ToString();
                        //book.Image = bookImage;
                        // Update to DB
                        context.SaveChanges();
                        Alert("Thay đổi thông tin sách thành công", Form_Alert.EnmType.Success);
                        Close();
                    }
                }
                else
                    return;
            }
            else
            {
                Alert("Dữ liệu không hợp lệ", Form_Alert.EnmType.Error);
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            bool isNewNameBook, isNewPublishDate, isNewAuthor, isNewLanguage, isNewPublisher,
                    isNewGenre, isNewQuantity, isNewPrice, isNewImage;
            using (BookStoreContext context = new BookStoreContext())
            {
                var book = context.Books
                        .Join(
                            context.Languages,
                            b => b.ID_Language,
                            lang => lang.ID_Language,
                            (b, lang) => new
                            {
                                b.ID_Book,
                                b.NameBook,
                                b.PublishDate,
                                b.Price,
                                b.Quantity,
                                b.Unit,
                                b.Image,
                                b.ID_Publisher,
                                b.ID_Genre,
                                lang.NameLanguage
                            })
                        //.Join(
                        //    context.Authors,
                        //    b => b.ID_Author,
                        //    auth => auth.ID_Author,
                        //    (b, auth) => new
                        //    {
                        //        b.ID_Book,
                        //        b.NameBook,
                        //        b.PublishDate,
                        //        b.Price,
                        //        b.Quantity,
                        //        b.Unit,
                        //        b.Image,
                        //        b.ID_Publisher,
                        //        b.ID_Genre,
                        //        b.NameLanguage,
                        //        auth.FullNameAuthor,
                        //    })
                        .Join(
                            context.Genres,
                            b => b.ID_Genre,
                            genre => genre.ID_Genre,
                            (b, genre) => new
                            {
                                b.ID_Book,
                                b.NameBook,
                                b.PublishDate,
                                b.Price,
                                b.Quantity,
                                b.Unit,
                                b.Image,
                                b.ID_Publisher,
                                b.ID_Genre,
                                b.NameLanguage,
                                genre.NameGenre,
                            })
                        .Join(
                            context.Publishers,
                            b => b.ID_Publisher,
                            publisher => publisher.ID_Publisher,
                            (b, publisher) => new
                            {
                                b.ID_Book,
                                b.NameBook,
                                b.PublishDate,
                                b.Price,
                                b.Quantity,
                                b.Unit,
                                b.Image,
                                b.NameLanguage,
                                b.NameGenre,
                                publisher.NamePublisher
                            })
                        .Where(b => b.ID_Book == ID_Book)
                        .Select(b => b)
                        .ToList()
                        .FirstOrDefault();

                isNewNameBook = tbNameBook.Text != book.NameBook;
                isNewPublishDate = tbPublishDate.Text != book.PublishDate.ToString("dd/MM/yyyy");
                //isNewAuthor = tbAuthor.Text != book.FullNameAuthor;
                isNewLanguage = cbbLanguage.Texts != book.NameLanguage;
                isNewPublisher = cbbPublisher.Texts != book.NamePublisher;
                isNewGenre = cbbGenre.Texts != book.NameGenre;
                isNewQuantity = Convert.ToInt32(tbQuantity.Text) != book.Quantity;
                isNewPrice = Convert.ToInt32(tbPrice.Text) != book.Price;

                if (book.Image != null)
                {
                    if (gpbBookImg.Image == null)
                    {
                        isNewImage = true;
                    }
                    else
                    {
                        if (gpbBookImg.ImageLocation != null)
                        {
                            isNewImage = true;
                        }
                        else
                        {
                            isNewImage = false;
                        }
                    }
                }
                else
                {
                    if (gpbBookImg.Image != null)
                    {
                        isNewImage = true;
                    }
                    else
                    {
                        isNewImage = false;
                    }
                }
                if (isNewNameBook || isNewPublishDate || isNewLanguage || isNewPublisher
                    || isNewGenre || isNewQuantity || isNewPrice || cbbUnit.SelectedItem != null || isNewImage)
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
    }
}