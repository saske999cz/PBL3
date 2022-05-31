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
    public partial class FormSuaSach : Form
    {
        private string ID_Book;

        public FormSuaSach(string ID_Book)
        {
            InitializeComponent();
            this.ID_Book = ID_Book;
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void FormSuaSach_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var book = context.Books
                    .Where(b => b.ID_Book == ID_Book)
                    .ToList()
                    .FirstOrDefault();
                tbNameBook.Text = book.NameBook;
                tbPublishDate.Text = book.PublishDate.ToString("dd/MM/yyyy");
                tbAuthor.Text = book.Author.FullNameAuthor.ToString();
                cbbLanguage.SelectedItem = book.Language.NameLanguage.ToString();
                cbbPublisher.SelectedItem = book.Publisher.NamePublisher.ToString();
                cbbGenre.SelectedItem = book.Genre.NameGenre.ToString();
                tbPrice.Text = book.Price.ToString();
                tbQuantity.Text = book.Quantity.ToString();
                cbUnit.SelectedItem = book.Unit;
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

        private void rjbtnOK_Click(object sender, EventArgs e)
        {

        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}