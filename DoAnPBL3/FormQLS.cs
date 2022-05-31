using DoAnPBL3.Models;
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
    public partial class FormQLS : Form
    {
        private int count;
        private string accountUsername;
        private string password;

        public FormQLS(string accountUsername, string password)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
            this.password = password;
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void FormQLS_Load(object sender, EventArgs e)
        {
            timer1.Tick += new System.EventHandler(timer1_Tick);
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
                count = listBooks.Count();
                dgvQLSNV.DataSource = listBooks;
                lblTSSDB.Text = listBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            new FormAddSach(accountUsername, password).Show();
            timer1.Start();
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("Edit");
        }

        private void btnDeleteSach_Click(object sender, EventArgs e)
        {
            if (dgvQLSNV.CurrentRow == null)
            {
                RJMessageBox.Show("Hệ thống chưa có mặt hàng sách nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ID_Book = dgvQLSNV.CurrentRow.Cells["ID"].Value.ToString();
                string NameBook = dgvQLSNV.CurrentRow.Cells["NameBook"].Value.ToString();
                DialogResult result = RJMessageBox.Show("Xác nhận xóa mặt hàng sách " + NameBook + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    new FormIdentify(accountUsername, password, ID_Book).Show();
                    timer1.Start();
                }
                else
                    return;
            }
        }

        private void dgvQLSNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Book = dgvQLSNV.CurrentRow.Cells["ID"].Value.ToString();
            new FormTTS(ID_Book).Show();
        }

        private void rjtbTKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
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
                            dgvQLSNV.DataSource = listBooks;
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
                            dgvQLSNV.DataSource = listBooks;
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
                    FormQLS_Load(sender, e);
                }
                // Sách tiếng việt
                else if (xuiSegmentSach.SelectedIndex == 1)
                {
                    dgvQLSNV.DataSource = context.Books
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
                    dgvQLSNV.DataSource = context.Books
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

        private void timer1_Tick(object sender, EventArgs e)
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
                            book.Price,
                        })
                    .ToList();
                var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                if (listBooks.Count() != count)
                {
                    dgvQLSNV.DataSource = listBooks;
                    lblTSSDB.Text = listBooks.Count().ToString();
                    lblSSTV.Text = listVietnameseBooks.Count().ToString();
                    lblSSTA.Text = listEnglishBooks.Count().ToString();
                    count = listBooks.Count();
                }
            }
        }
    }
}
