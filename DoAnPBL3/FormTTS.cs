using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormTTS : Form
    {
        private string ID_Book;
        public FormTTS(string ID_Book)
        {
            InitializeComponent();
            this.ID_Book = ID_Book;
        }

        private void FormTTS_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                // ==========================     LINQ Cách 1    ========================== 
                //var book = (from b in context.Books
                //           join language in context.Languages
                //           on b.ID_Language equals language.ID_Language
                //           join author in context.Authors
                //           on b.ID_Author equals author.ID_Author
                //           join publisher in context.Publishers
                //           on b.ID_Publisher equals publisher.ID_Publisher
                //           join genre in context.Genres
                //           on b.ID_Genre equals genre.ID_Genre
                //           where (b.ID_Book == ID_Book)
                //           select new
                //           {
                //               b.ID_Book,
                //               b.NameBook,
                //               b.PublishDate,
                //               b.Quantity,
                //               b.Price,
                //               b.Image,
                //               author.FullNameAuthor,
                //               language.NameLanguage,
                //               genre.NameGenre,
                //               publisher.NamePublisher
                //           }).ToList().FirstOrDefault();
                // ==========================     LINQ Cách 2 (Lambda Expression) ==========================
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
                                b.ID_Author,
                                b.ID_Publisher,
                                b.ID_Genre,
                                lang.NameLanguage
                            })
                        .Join(
                            context.Authors,
                            b => b.ID_Author,
                            author => author.ID_Author,
                            (b, author) => new
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
                                author.FullNameAuthor,
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
                                b.FullNameAuthor,
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
                                b.FullNameAuthor,
                                b.NameGenre,
                                publisher.NamePublisher
                            })
                        .Where(b => b.ID_Book == ID_Book)
                        .Select(b => b)
                        .ToList()
                        .FirstOrDefault();
                tbIDBook.Text = ID_Book;
                tbNameBook.Text = book.NameBook;
                tbPublishDate.Text = book.PublishDate.ToString("dd/MM/yyyy");
                tbLanguage.Text = book.NameLanguage;
                tbAuthor.Text = book.FullNameAuthor;
                tbPublisher.Text = book.NameLanguage;
                tbGenre.Text = book.NameGenre;
                tbPrice.Text = book.Price.ToString() + "VNĐ";
                tbQuantity.Text = book.Quantity.ToString();
                tbUnit.Text = book.Unit;
                if (book.Image != null)
                {
                    MemoryStream memoryStream = new MemoryStream(book.Image);
                    gpbBookImg.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    gpbBookImg.Image = null;
                }
            }
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
