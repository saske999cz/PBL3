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
        private readonly string accountUsername;
        private readonly string password;

        public FormQLS(string accountUsername, string password)
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

        private void FormQLS_Load(object sender, EventArgs e)
        {
            dgvQLSNV.RowHeadersVisible = true;
            dgvQLSNV.BorderStyle = BorderStyle.FixedSingle;
            dgvQLSNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLSNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
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
                dgvQLSNV.DataSource = listBooks;
                lblTSSDB.Text = listBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
            }
        }

        private void BtnAddSach_Click(object sender, EventArgs e)
        {
            FormAddSach formAddSach = new FormAddSach(accountUsername, password);
            formAddSach.RefreshData += new FormAddSach.LoadData(FormQLS_Load);
            formAddSach.ShowDialog();
        }

        private void BtnSuaSach_Click(object sender, EventArgs e)
        {
            if (dgvQLSNV.CurrentRow == null)
                RJMessageBox.Show("Hệ thống chưa có mặt hàng sách nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string ID_Book = dgvQLSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
                FormSuaSach formSuaSach = new FormSuaSach(ID_Book);
                formSuaSach.RefreshData += new FormSuaSach.LoadData(FormQLS_Load);
                formSuaSach.ShowDialog();
            }
        }

        private void BtnDeleteSach_Click(object sender, EventArgs e)
        {
            if (dgvQLSNV.CurrentRow == null)
                RJMessageBox.Show("Hệ thống chưa có mặt hàng sách nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string ID_Book = dgvQLSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
                string NameBook = dgvQLSNV.CurrentRow.Cells["NameBook"].Value.ToString();
                DialogResult result = RJMessageBox.Show("Xác nhận xóa mặt hàng sách " + NameBook + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    FormIdentify formIdentify = new FormIdentify(accountUsername, password, ID_Book);
                    formIdentify.RefreshData += new FormIdentify.LoadData(FormQLS_Load);
                    formIdentify.Show();
                }
                else
                    return;
            }
        }

        private void DgvQLSNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Book = dgvQLSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
            new FormTTS(ID_Book).ShowDialog();
        }

        private void RjtbTKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTKS.PerformClick();
                e.Handled = true;
            }
        }

        private void BtnTKS_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                if (rjtbTKS.Texts.Trim() == "")
                    RJMessageBox.Show("Vui lòng điền thông tin sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            .Select(book => book);
                    if (rjtbTKS.Texts.Length == 5)
                    {
                        int numFindBook = listBooks
                            .Where(book => book.ID_Book == rjtbTKS.Texts)
                            .Count();
                        if (numFindBook == 0)
                            RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            dgvQLSNV.DataSource = listBooks
                                .Where(book => book.ID_Book == rjtbTKS.Texts)
                                .ToList();
                    }
                    else
                    {
                        int numFindBook = listBooks
                            .Where(book => book.NameBook.Contains(rjtbTKS.Texts))
                            .Count();
                        if (numFindBook == 0)
                            RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            dgvQLSNV.DataSource = listBooks
                                .Where(book => book.NameBook.Contains(rjtbTKS.Texts))
                                .ToList();
                    }
                }
            }
        }

        private void XuiSegmentSach_Click(object sender, EventArgs e)
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
                var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt").ToList();
                var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh").ToList();
                lblTSSDB.Text = listBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
                // Tất cả
                if (xuiSegmentSach.SelectedIndex == 0)
                    dgvQLSNV.DataSource = listBooks;
                // Sách tiếng việt
                else if (xuiSegmentSach.SelectedIndex == 1)
                    dgvQLSNV.DataSource = listVietnameseBooks;
                // Sách tiếng anh
                else
                    dgvQLSNV.DataSource = listEnglishBooks;
            }
        }
    }
}
