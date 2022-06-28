using DoAnPBL3.BLL;
using DoAnPBL3.Models;
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
        private readonly string ID_Book;
        public FormTTS(string ID_Book)
        {
            InitializeComponent();
            this.ID_Book = ID_Book;
        }

        private void FormTTS_Load(object sender, EventArgs e)
        {
            ShowInfo(BLL_QLBS.Instance.GetBookByID(ID_Book));
        }

        private void ShowInfo(Book book)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbIDBook.Text = book.ID_Book;
            tbNameBook.Text = book.NameBook;
            tbPublishDate.Text = book.PublishDate.ToString("dd/MM/yyyy");
            tbAuthor.Text = book.NameAuthor;
            tbLanguage.Text = BLL_QLBS.Instance.GetNameLanguageByID(book.ID_Language);
            tbPublisher.Text = BLL_QLBS.Instance.GetNamePublisherByID(book.ID_Publisher);
            tbGenre.Text = BLL_QLBS.Instance.GetNameGenreByID(book.ID_Genre);
            tbQuantity.Text = book.Quantity.ToString();
            tbPrice.Text = book.Price.ToString("##,#") + "VNĐ";
            tbUnit.Text = book.Unit;
            if (book.Image == null)
                gpbBookImg.Image = null;
            else
                gpbBookImg.Image = Image.FromFile(Path.Combine(projectDirectory, book.Image));
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
