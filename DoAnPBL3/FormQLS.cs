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

        public FormQLS()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void FormQLS_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listBooks = context.Books.Join(
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
                                        });
                var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                count = listBooks.ToList().Count();
                dgvQLSNV.DataSource = listBooks.ToList();
                lblTSSDB.Text = listBooks.ToList().Count().ToString();
                lblSSTV.Text = listVietnameseBooks.ToList().Count().ToString();
                lblSSTA.Text = listEnglishBooks.ToList().Count().ToString();
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            new FormAddSach().Show();
            timer1.Start();
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
                new FormSuaNV(ID_Book).Show();
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
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        Book book = context.Books.Find(ID_Book);
                        context.Books.Remove(book);
                        context.SaveChanges();
                    }
                    FormQLS_Load(sender, e);
                    Alert("Xóa mặt hàng sách thành công", Form_Alert.enmType.Success);
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
                    dgvQLSNV.DataSource = context.Books.Join(
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
                                        .Where(lang => lang.NameLanguage == "Tiếng Việt")
                                        .ToList();
                }
                // Sách tiếng anh
                else
                {
                    dgvQLSNV.DataSource = context.Books.Join(
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
                                        .Where(lang => lang.NameLanguage == "Tiếng Anh")
                                        .ToList();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listBooks = context.Books.Join(
                                        context.Languages,
                                        book => book.ID_Language,
                                        lang => lang.ID_Language,
                                        (book, lang) => new
                                        {
                                            book.ID_Book,
                                            book.NameBook,
                                            lang.NameLanguage,
                                            book.Quantity,
                                            book.Price,
                                        });
                var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                if (listBooks.ToList().Count() != count)
                {
                    dgvQLSNV.DataSource = listBooks.ToList();
                    lblTSSDB.Text = listBooks.ToList().Count().ToString();
                    lblSSTV.Text = listVietnameseBooks.ToList().Count().ToString();
                    lblSSTA.Text = listEnglishBooks.ToList().Count().ToString();
                    count = listBooks.ToList().Count();
                }
            }
        }
    }
}
