using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormQLBSNV : Form
    {
        private string accountUsername;

        public FormQLBSNV(string accountUsername)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void FormQLBSNV_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listBooks = context.Books
                    .Join(
                        context.Languages,
                        book => book.ID_Language,
                        language => language.ID_Language,
                        (book, language) => new
                        {
                            book.ID_Book,
                            book.NameBook,
                            language.NameLanguage,
                            book.Quantity,
                            book.Price
                        })
                    .ToList();
                var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                dgvQLBSNV.DataSource = listBooks;
                dgvQLBSNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                lblTSSDB.Text = listBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
            }
        }

        private void rjbtnBuy_Click(object sender, EventArgs e)
        {
            new FormCart(accountUsername).ShowDialog();
            FormQLBSNV_Load(sender, e);
        }

        private void rjbtnOrder_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("Đặt hàng");
        }

        private void rjbtnAddCart_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("Thêm vào giỏ hàng");
        }

        private void rjtbTKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTKS.PerformClick();
                e.Handled = true;
            }
        }

        private void btnTKS_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                if (rjtbTKS.Texts.Trim() == "")
                {
                    RJMessageBox.Show("Vui lòng điền thông tin sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rjtbTKS.Texts.Length == 5)
                    {
                        var listBooks = context.Books
                            .Join(
                                context.Languages,
                                book => book.ID_Language,
                                lang => lang.ID_Language,
                                (book, lang) => new
                                {
                                    book.ID_Book,
                                    book.NameBook,
                                    lang.NameLanguage,
                                    book.Quantity,
                                    book.Price
                                })
                            .Where(book => book.ID_Book == rjtbTKS.Texts)
                            .Select(book => book)
                            .ToList();
                        if (listBooks.Count() == 0)
                            RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            dgvQLBSNV.DataSource = listBooks;
                    }
                    else
                    {
                        var listBooks = context.Books
                            .Join(
                                context.Languages,
                                book => book.ID_Language,
                                lang => lang.ID_Language,
                                (book, lang) => new
                                {
                                    book.ID_Book,
                                    book.NameBook,
                                    lang.NameLanguage,
                                    book.Quantity,
                                    book.Price
                                })
                            .Where(book => book.NameBook.Contains(rjtbTKS.Texts))
                            .Select(book => book)
                            .ToList();
                        if (listBooks.Count() == 0)
                            RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            dgvQLBSNV.DataSource = listBooks;
                    }
                }
            }
        }

        private void xuiSegmentSach_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                // Tất cả
                if (xuiSegmentSach.SelectedIndex == 0)
                {
                    FormQLBSNV_Load(sender, e);
                }
                // Sách tiếng việt
                else if (xuiSegmentSach.SelectedIndex == 1)
                {
                    dgvQLBSNV.DataSource = context.Books
                        .Join(
                            context.Languages,
                            book => book.ID_Language,
                            language => language.ID_Language,
                            (book, language) => new
                            {
                                book.ID_Book,
                                book.NameBook,
                                language.NameLanguage,
                                book.Quantity,
                                book.Price,
                            })
                        .Where(lang => lang.NameLanguage == "Tiếng Việt")
                        .ToList();
                }
                // Sách tiếng anh
                else
                {
                    dgvQLBSNV.DataSource = context.Books
                        .Join(
                            context.Languages,
                            book => book.ID_Language,
                            language => language.ID_Language,
                            (book, language) => new
                            {
                                book.ID_Book,
                                book.NameBook,
                                language.NameLanguage,
                                book.Quantity,
                                book.Price,
                            })
                        .Where(lang => lang.NameLanguage == "Tiếng Anh")
                        .ToList();
                }
            }
        }

        private void dgvQLBSNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Book = dgvQLBSNV.CurrentRow.Cells["ID"].Value.ToString();
            new FormTTS(ID_Book).Show();
        }
    }
}
