using DoAnPBL3.BLL;
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
            GetAllInfoBooks();
            dgvQLSNV.RowHeadersVisible = true;
            dgvQLSNV.BorderStyle = BorderStyle.FixedSingle;
            dgvQLSNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLSNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            List<Book> listBooks = BLL_QLBS.Instance.GetBooks();
            DataTable data = new DataTable();
            CreateCol(data);
            if (listBooks != null)
            {
                foreach (Book book in listBooks)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                }
                dgvQLSNV.DataSource = data;
            }
            else
            {
                dgvQLSNV.DataSource = null;
                totalBook.Text = "0";
                vietnameseBook.Text = "0";
                englishBook.Text = "0";
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
                FormSuaSach formSuaSach = new FormSuaSach(GetID_Book());
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
                string NameBook = dgvQLSNV.CurrentRow.Cells["NameBook"].Value.ToString();
                DialogResult result = RJMessageBox.Show("Xác nhận xóa mặt hàng sách " + NameBook + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    FormIdentify formIdentify = new FormIdentify(accountUsername, password, GetID_Book());
                    formIdentify.RefreshData += new FormIdentify.LoadData(FormQLS_Load);
                    formIdentify.Show();
                }
                else
                    return;
            }
        }

        private void DgvQLSNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTS(GetID_Book()).ShowDialog();
        }

        public string GetID_Book()
        {
            return dgvQLSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
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
            DataTable data = new DataTable();
            CreateCol(data);
            if (rjtbTKS.Texts.Trim() == "")
                RJMessageBox.Show("Vui lòng điền thông tin sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rjtbTKS.Texts.Contains(""))
            {

            }
            else
            {
                List<Book> listBooksByName = BLL_QLBS.Instance.GetBooksByNameBook(rjtbTKS.Texts);
                if (listBooksByName != null)
                {
                    foreach (Book book in listBooksByName)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLSNV.DataSource = data;
                }
                else
                {
                    List<Book> listBooksByAuthor = BLL_QLBS.Instance.GetBooksByNameAuthor(rjtbTKS.Texts);
                    if (listBooksByAuthor != null)
                    {
                        foreach (Book book in listBooksByName)
                        {
                            DataRow dataRow = data.NewRow();
                            data.Rows.Add(CreateRow(dataRow, book));
                        }
                        dgvQLSNV.DataSource = data;
                    }
                    else
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XuiSegmentSach_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            if (xuiSegmentSach.SelectedIndex == 0)
            {
                List<Book> listBooks = BLL_QLBS.Instance.GetBooks();
                if (listBooks == null)
                {
                    dgvQLSNV.DataSource = null;
                }
                else
                {
                    foreach (Book book in listBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLSNV.DataSource = data;
                }
            }
            // Sách tiếng việt
            else if (xuiSegmentSach.SelectedIndex == 1)
            {
                List<Book> listVietnameseBooks = BLL_QLBS.Instance.GetVietnameseBooks();
                if (listVietnameseBooks == null)
                {
                    dgvQLSNV.DataSource = null;
                }
                else
                {
                    foreach (Book book in listVietnameseBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLSNV.DataSource = data;
                }
            }
            // Sách tiếng anh
            else
            {
                List<Book> listEnglishBooks = BLL_QLBS.Instance.GetEnglishBooks();
                if (listEnglishBooks == null)
                {
                    dgvQLSNV.DataSource = null;
                }
                else
                {
                    foreach (Book book in listEnglishBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLSNV.DataSource = data;
                }
            }
        }

        private void GetAllInfoBooks()
        {
            totalBook.Text = BLL_QLBS.Instance.GetNumberTotalBook().ToString();
            vietnameseBook.Text = BLL_QLBS.Instance.GetNumberTotalVietnameseBook().ToString();
            englishBook.Text = BLL_QLBS.Instance.GetNumberTotalEnglishBook().ToString();
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Book", typeof(string)),
                new DataColumn("NameBook", typeof(string)),
                new DataColumn("PublishDate", typeof(string)),
                new DataColumn("NameAuthor", typeof(string)),
                new DataColumn("NameLanguage", typeof(string)),
                new DataColumn("NameGenre", typeof(string)),
                new DataColumn("Price", typeof(string)),
                new DataColumn("Quantity", typeof(int)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, Book book)
        {
            dataRow["ID_Book"] = book.ID_Book;
            dataRow["NameBook"] = book.NameBook;
            dataRow["PublishDate"] = book.PublishDate.ToString("dd/MM/yyyy");
            dataRow["NameAuthor"] = book.NameAuthor;
            dataRow["NameLanguage"] = BLL_QLBS.Instance.GetNameLanguageByID(book.ID_Language);
            dataRow["NameGenre"] = BLL_QLBS.Instance.GetNameGenreByID(book.ID_Genre);
            dataRow["Price"] = book.Price.ToString("##,#") + "VNĐ";
            dataRow["Quantity"] = book.Quantity;
            return dataRow;
        }
    }
}
