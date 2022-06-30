using DoAnPBL3.BLL;
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

    public partial class FormQLBS : Form
    {
        private int ID_Language;
        private int ID_Publisher;
        private int ID_Genre;
        public FormQLBS(string theme)
        {
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    btnTKS.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    lblTotalBook.ForeColor = Color.FromArgb(124, 141, 181);
                    lblVietnameseBook.ForeColor = Color.FromArgb(124, 141, 181);
                    lblEnglishBook.ForeColor = Color.FromArgb(124, 141, 181);
                    panelHeader.BackColor = Color.FromArgb(30, 30, 70);
                    englishBook.ForeColor = Color.White;
                    vietnameseBook.ForeColor = Color.White;
                    totalBook.ForeColor = Color.White;
                    btnTKS.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKS.BackColor = Color.FromArgb(23, 21, 35);
                    rjtbTKS.BorderColor = Color.FromArgb(23, 21, 35);
                    rjtbTKS.ForeColor = Color.Silver;
                    rjtbTKS.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLBS.BackgroundColor = Color.FromArgb(24, 37, 65);
                    break;
                case "Dark":
                    btnTKS.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    lblTotalBook.ForeColor = Color.FromArgb(124, 141, 181);
                    lblVietnameseBook.ForeColor = Color.FromArgb(124, 141, 181);
                    lblEnglishBook.ForeColor = Color.FromArgb(124, 141, 181);
                    panelHeader.BackColor = Color.FromArgb(38, 38, 40);
                    englishBook.ForeColor = Color.White;
                    vietnameseBook.ForeColor = Color.White;
                    totalBook.ForeColor = Color.White;
                    btnTKS.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKS.BackColor = Color.FromArgb(18, 18, 18);
                    rjtbTKS.BorderColor = Color.FromArgb(18, 18, 18);
                    rjtbTKS.ForeColor = Color.Silver;
                    rjtbTKS.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLBS.BackgroundColor = Color.FromArgb(34, 31, 46);
                    break;
                case "Light":
                    btnTKS.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    lblTotalBook.ForeColor = Color.Black;
                    lblVietnameseBook.ForeColor = Color.Black;
                    lblEnglishBook.ForeColor = Color.Black;
                    panelHeader.BackColor = Color.FromArgb(210, 200, 210);
                    englishBook.ForeColor = Color.Black;
                    vietnameseBook.ForeColor = Color.Black;
                    totalBook.ForeColor = Color.Black;
                    btnTKS.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKS.BackColor = Color.FromArgb(255, 255, 255);
                    rjtbTKS.BorderColor = Color.FromArgb(180, 180, 180);
                    rjtbTKS.ForeColor = Color.DimGray;
                    rjtbTKS.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLBS.BackgroundColor = Color.Silver;
                    break;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void BtnSXS_MouseEnter(object sender, EventArgs e)
        {
            btnSXS.BackColor = RGBColors.color4;
        }

        private void BtnSXS_MouseLeave(object sender, EventArgs e)
        {
            btnSXS.BackColor = Color.RoyalBlue;
        }

        private void BtnSXS_Click(object sender, EventArgs e)
        {
            rjDropDownMenuSXS.Show(btnSXS, new Point(0, btnSXS.Height));
        }

        private void FormQLBS_Load(object sender, EventArgs e)
        {
            GetAllInfoBooks();
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng hiện có";
            dgvQLBS.RowHeadersVisible = true;
            dgvQLBS.BorderStyle = BorderStyle.FixedSingle;
            dgvQLBS.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLBS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
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
                dgvQLBS.DataSource = data;
            }
            else
            {
                dgvQLBS.DataSource = null;
                totalBook.Text = "0";
                vietnameseBook.Text = "0";
                englishBook.Text = "0";
            }
            rjDropDownMenuSXS.IsMainMenu = false;
        }

        private void ChữCáiGiảmDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng hiện có";
            List<Book> listBooks = BLL_QLBS.Instance.SortByNameBookDESC();
            if (listBooks == null)
            {
                dgvQLBS.DataSource = null;
            }
            else
            {
                foreach (Book book in listBooks)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                }
                dgvQLBS.DataSource = data;
            }
        }

        private void ChữCáiTăngDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng hiện có";
            List<Book> listBooks = BLL_QLBS.Instance.SortByNameBookASC();
            if (listBooks == null)
            {
                dgvQLBS.DataSource = null;
            }
            else
            {
                foreach (Book book in listBooks)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                }
                dgvQLBS.DataSource = data;
            }
        }

        private void GiáMuaSáchTăngDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng hiện có";
            List<Book> listBooks = BLL_QLBS.Instance.SortByPriceASC();
            if (listBooks == null)
            {
                dgvQLBS.DataSource = null;
            }
            else
            {
                foreach (Book book in listBooks)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                }
                dgvQLBS.DataSource = data;
            }
        }

        private void GiáMuaSáchGiảmDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng hiện có";
            List<Book> listBooks = BLL_QLBS.Instance.SortByPriceDESC();
            if (listBooks == null)
            {
                dgvQLBS.DataSource = null;
            }
            else
            {
                foreach (Book book in listBooks)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                }
                dgvQLBS.DataSource = data;
            }
        }

        private void MứcĐộBánChạyTăngDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng đã bán";
            using (BookStoreContext context = new BookStoreContext())
            {
                dgvQLBS.DataSource = (from orderDetail in context.OrderDetails
                                      group orderDetail by orderDetail.ID_Book into ord
                                      select new
                                      {
                                          ID_Book = ord.Key,
                                          Quantity = ord.Sum(o => o.Quantity)
                                      } into o
                                      join book in context.Books on o.ID_Book equals book.ID_Book
                                      join lang in context.Languages on book.ID_Language equals lang.ID_Language
                                      join publisher in context.Publishers on book.ID_Publisher equals publisher.ID_Publisher
                                      join genre in context.Genres on book.ID_Genre equals genre.ID_Genre
                                      select new
                                      {
                                          book.ID_Book,
                                          book.NameBook,
                                          book.PublishDate,
                                          book.NameAuthor,
                                          lang.NameLanguage,
                                          publisher.NamePublisher,
                                          genre.NameGenre,
                                          o.Quantity,
                                          book.Price
                                      })
                                      .OrderBy(b => b.Quantity)
                                      .ToList();
            }
        }

        private void MứcĐộBánChạyGiảmDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng đã bán";
            using (BookStoreContext context = new BookStoreContext())
            {
                dgvQLBS.DataSource = (from orderDetail in context.OrderDetails
                                      group orderDetail by orderDetail.ID_Book into ord
                                      select new
                                      {
                                          ID_Book = ord.Key,
                                          Quantity = ord.Sum(o => o.Quantity)
                                      } into o
                                      join book in context.Books on o.ID_Book equals book.ID_Book
                                      join lang in context.Languages on book.ID_Language equals lang.ID_Language
                                      join publisher in context.Publishers on book.ID_Publisher equals publisher.ID_Publisher
                                      join genre in context.Genres on book.ID_Genre equals genre.ID_Genre
                                      select new
                                      {
                                          book.ID_Book,
                                          book.NameBook,
                                          book.PublishDate,
                                          book.NameAuthor,
                                          lang.NameLanguage,
                                          publisher.NamePublisher,
                                          genre.NameGenre,
                                          o.Quantity,
                                          book.Price
                                      })
                                      .OrderByDescending(b => b.Quantity)
                                      .ToList();
            }
        }

        private void SốLượngSáchHiệnCóTăngDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng hiện có";
            List<Book> listBooks = BLL_QLBS.Instance.SortByQuantityASC();
            if (listBooks == null)
            {
                dgvQLBS.DataSource = null;
            }
            else
            {
                foreach (Book book in listBooks)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                }
                dgvQLBS.DataSource = data;
            }
        }

        private void SốLượngSáchHiệnCóGiảmDầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng hiện có";
            List<Book> listBooks = BLL_QLBS.Instance.SortByQuantityDESC();
            if (listBooks == null)
            {
                dgvQLBS.DataSource = null;
            }
            else
            {
                foreach (Book book in listBooks)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                }
                dgvQLBS.DataSource = data;
            }
        }

        private void DgvQLBS_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Book = dgvQLBS.CurrentRow.Cells["ID_Book"].Value.ToString();
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
            DataTable data = new DataTable();
            CreateCol(data);
            if (rjtbTKS.Texts.Trim() == "")
                RJMessageBox.Show("Vui lòng điền thông tin sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rjtbTKS.Texts.Contains("B0"))
            {
                Book book = BLL_QLBS.Instance.GetBookByID(rjtbTKS.Texts);
                if (book == null)
                      RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                    dgvQLBS.DataSource = data;
                }
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
                    dgvQLBS.DataSource = data;
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
                        dgvQLBS.DataSource = data;
                    }
                    else
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                new DataColumn("NamePublisher", typeof(string)),
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
            dataRow["NamePublisher"] = BLL_QLBS.Instance.GetNamePublisherByID(book.ID_Publisher);
            dataRow["NameGenre"] = BLL_QLBS.Instance.GetNameGenreByID(book.ID_Genre);
            dataRow["Price"] = book.Price.ToString("##,#") + "VNĐ";
            dataRow["Quantity"] = book.Quantity;
            return dataRow;
        }

        private void CbbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCriteria.SelectedIndex == 0)
            {
                if (cbbCritiaDetail.Items.Count > 0)
                    cbbCritiaDetail.Items.Clear();
                List<Language> languages = BLL_QLBS.Instance.GetAllLanguages();
                if (languages != null)
                {
                    foreach (Language language in languages)
                    {
                        cbbCritiaDetail.Items.Add(language.NameLanguage);
                    }
                }
                else
                    cbbCritiaDetail.Items.Add("");
            }
            else if (cbbCriteria.SelectedIndex == 1)
            {
                if (cbbCritiaDetail.Items.Count > 0)
                    cbbCritiaDetail.Items.Clear();
                List<Publisher> publishers = BLL_QLBS.Instance.GetAllPublishers();
                if (publishers != null)
                {
                    foreach (Publisher publisher in publishers)
                    {
                        cbbCritiaDetail.Items.Add(publisher.NamePublisher);
                    }
                }
                else
                    cbbCritiaDetail.Items.Add("");
            }
            else
            {
                if (cbbCritiaDetail.Items.Count > 0)
                    cbbCritiaDetail.Items.Clear();
                List<Genre> genres = BLL_QLBS.Instance.GetAllGenres();
                if (genres != null)
                {
                    foreach (Genre genre in genres)
                    {
                        cbbCritiaDetail.Items.Add(genre.NameGenre);
                    }
                }
                else
                    cbbCritiaDetail.Items.Add("");
            }
        }

        private void CbbCritiaDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCriteria.SelectedItem.ToString() == "Ngôn ngữ")
                ID_Language = cbbCritiaDetail.SelectedIndex + 1;
            else if (cbbCriteria.SelectedItem.ToString() == "Nhà xuất bản")
                ID_Publisher = cbbCritiaDetail.SelectedIndex + 1;
            else
                ID_Genre = cbbCritiaDetail.SelectedIndex + 1;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            dgvQLBS.Columns["Quantity"].HeaderCell.Value = "Số lượng hiện có";
            DataTable data = new DataTable();
            CreateCol(data);
            if (cbbCritiaDetail.SelectedItem == null)
                RJMessageBox.Show("Vui lòng chọn tiêu chí để lọc danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cbbCriteria.SelectedItem.ToString() == "Ngôn ngữ")
            {
                List<Book> listBooks = BLL_QLBS.Instance.GetBooksByIDLanguage(ID_Language);
                if (listBooks == null)
                    dgvQLBS.DataSource = null;
                else
                {
                    foreach (Book book in listBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLBS.DataSource = data;
                }
            }
            else if (cbbCriteria.SelectedItem.ToString() == "Nhà xuất bản")
            {
                List<Book> listBooks = BLL_QLBS.Instance.GetBooksByIDPublisher(ID_Publisher);
                if (listBooks == null)
                    dgvQLBS.DataSource = null;
                else
                {
                    foreach (Book book in listBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLBS.DataSource = data;
                }
            }
            else
            {
                List<Book> listBooks = BLL_QLBS.Instance.GetBooksByIDGenre(ID_Genre);
                if (listBooks == null)
                    dgvQLBS.DataSource = null;
                else
                {
                    foreach (Book book in listBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLBS.DataSource = data;
                }
            }
        }
    }
}