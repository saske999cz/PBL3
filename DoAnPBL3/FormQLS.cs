using DoAnPBL3.Models;
using PagedList;
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
        private readonly string accountUsername;
        private readonly string password;
        private int pageNumber = 1;
        IPagedList<Book> listBooks;

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

        public async Task<IPagedList<Book>> GetPagedListAsync(int pageNumber = 1)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    if (MainMenuNV.windowState == FormWindowState.Maximized)
                        return context.Books.OrderBy(book => book.ID_Book).ToPagedList(pageNumber, 22);
                    else
                        return context.Books.OrderBy(book => book.ID_Book).ToPagedList(pageNumber, 14);
                }
            });
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                if (listBooks.HasPreviousPage)
                {
                    listBooks = await GetPagedListAsync(--pageNumber);
                    btnPrevious.Enabled = listBooks.HasPreviousPage;
                    btnNext.Enabled = listBooks.HasNextPage;
                    dgvQLSNV.DataSource = listBooks
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
                    lblPageNumber.Text = string.Format("Trang {0}/{1}", pageNumber, listBooks.PageCount);
                }
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                if (listBooks.HasNextPage)
                {
                    listBooks = await GetPagedListAsync(++pageNumber);
                    btnPrevious.Enabled = listBooks.HasPreviousPage;
                    btnNext.Enabled = listBooks.HasNextPage;
                    dgvQLSNV.DataSource = listBooks
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
                    lblPageNumber.Text = string.Format("Trang {0}/{1}", pageNumber, listBooks.PageCount);
                }
            }
        }

        private async void FormQLS_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            listBooks = await GetPagedListAsync();
            using (BookStoreContext context = new BookStoreContext())
            {
                var listAllBooks = context.Books
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
                var listVietnameseBooks = listAllBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listAllBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                lblTSSDB.Text = listAllBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
                btnPrevious.Enabled = listBooks.HasPreviousPage;
                btnNext.Enabled = listBooks.HasNextPage;
                dgvQLSNV.DataSource = listBooks
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
                lblPageNumber.Text = string.Format("Trang {0}/{1}", pageNumber, listBooks.PageCount);
            }
        }

        private void btnAddSach_Click(object sender, EventArgs e)
        {
            new FormAddSach(accountUsername, password).ShowDialog();
            timer1.Start();
            //FormQLS_Load(sender, e);
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (dgvQLSNV.CurrentRow == null)
            {
                RJMessageBox.Show("Hệ thống chưa có mặt hàng sách nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ID_Book = dgvQLSNV.CurrentRow.Cells["ID"].Value.ToString();
                new FormSuaSach(ID_Book).ShowDialog();
            }
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
                    new FormIdentify(accountUsername, password, ID_Book).ShowDialog();
                    //FormQLS_Load(sender, e);
                    timer1.Start();
                }
                else
                    return;
            }
        }

        private void dgvQLSNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Book = dgvQLSNV.CurrentRow.Cells["ID"].Value.ToString();
            new FormTTS(ID_Book).ShowDialog();
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

        private async void xuiSegmentSach_Click(object sender, EventArgs e)
        {
            listBooks = await GetPagedListAsync(pageNumber);

            using (BookStoreContext context = new BookStoreContext())
            {
                var listAllBooks = context.Books
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
                var listVietnameseBooks = listAllBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listAllBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                lblTSSDB.Text = listAllBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
                // Tất cả
                if (xuiSegmentSach.SelectedIndex == 0)
                {
                    FormQLS_Load(sender, e);
                }
                // Sách tiếng việt
                else if (xuiSegmentSach.SelectedIndex == 1)
                {
                    btnPrevious.Enabled = listBooks.HasPreviousPage;
                    btnNext.Enabled = listBooks.HasNextPage;
                    dgvQLSNV.DataSource = listBooks
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
                                    .Where(book => book.NameLanguage == "Tiếng Việt")
                                    .ToList();
                    lblPageNumber.Text = string.Format("Trang {0}/{1}", pageNumber, listBooks.PageCount);
                }
                // Sách tiếng anh
                else
                {
                    btnPrevious.Enabled = listBooks.HasPreviousPage;
                    btnNext.Enabled = listBooks.HasNextPage;
                    dgvQLSNV.DataSource = listBooks
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
                                    .Where(book => book.NameLanguage == "Tiếng Anh")
                                    .ToList();
                    lblPageNumber.Text = string.Format("Trang {0}/{1}", pageNumber, listBooks.PageCount);
                }
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            //using (BookStoreContext context = new BookStoreContext())
            //{
            //    var listBooks = context.Books
            //        .Join(
            //            context.Languages,
            //            book => book.ID_Language,
            //            language => language.ID_Language,
            //            (book, language) => new
            //            {
            //                book.ID_Book,
            //                book.NameBook,
            //                language.NameLanguage,
            //                book.Quantity,
            //                book.Price,
            //            })
            //        .ToList();
            //    var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt");
            //    var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh");
            //    if (listBooks.Count() != count)
            //    {
            //        dgvQLSNV.DataSource = listBooks;
            //        lblTSSDB.Text = listBooks.Count().ToString();
            //        lblSSTV.Text = listVietnameseBooks.Count().ToString();
            //        lblSSTA.Text = listEnglishBooks.Count().ToString();
            //        count = listBooks.Count();
            //    }
            //}
            listBooks = await GetPagedListAsync(pageNumber);
            using (BookStoreContext context = new BookStoreContext())
            {
                var listAllBooks = context.Books
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
                var listVietnameseBooks = listAllBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listAllBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                lblTSSDB.Text = listAllBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
                btnPrevious.Enabled = listBooks.HasPreviousPage;
                btnNext.Enabled = listBooks.HasNextPage;
                dgvQLSNV.DataSource = listBooks
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
                lblPageNumber.Text = string.Format("Trang {0}/{1}", pageNumber, listBooks.PageCount);
            }
        }
    }
}
