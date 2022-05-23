using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Sach")]
    public class Book
    {
        public Book()
        {
            //Book_Genres = new HashSet<Book_Genre>();
            //Book_Authors = new HashSet<Book_Author>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Book(string id_book, string nameBook, DateTime publishDate, int quantity, int price, 
            string unit, int ID_Language, int ID_Author, int ID_Publisher, int ID_Genre, byte[] bookImage)
        {
            ID_Book = id_book;
            NameBook = nameBook;
            PublishDate = publishDate;
            Quantity = quantity;
            Price = price;
            Unit = unit;
            this.ID_Language = ID_Language;
            this.ID_Author = ID_Author;
            this.ID_Publisher = ID_Publisher;
            this.ID_Genre = ID_Genre;
            Image = bookImage;
        }

        [Key]
        [Column("ID_Sach")]
        [StringLength(100)]
        [Required(ErrorMessage = "ID của sách không được để trống")]
        public string ID_Book { get; set; }

        [Column("TenSach")]
        [StringLength(255)]
        [Required(ErrorMessage = "Tên sách không được để trống")]
        public string NameBook { get; set; }

        [Column("NgayPhatHanh")]
        [Required(ErrorMessage = "Ngày phát hành của sách không được để trống")]
        public DateTime PublishDate { get; set; }

        [Column("SoLuong")]
        [Required(ErrorMessage = "Số lượng sách không được để trống")]
        public int Quantity { get; set; }

        [Column("GiaTien")]
        [Required(ErrorMessage = "Giá tiền của sách không được để trống")]
        public int Price { get; set; }

        [Column("DonVi")]
        [StringLength(50)]
        [Required(ErrorMessage = "Đơn vị của sách không được để trống")]
        public string Unit { get; set; }

        [Column("ID_NgonNgu")]
        [Required(ErrorMessage = "ID ngôn ngữ của sách không được để trống")]
        public int ID_Language { get; set; }

        [Column("ID_TacGia")]
        [Required]
        public int ID_Author { get; set; }

        [Column("ID_NhaXuatBan")]
        [Required(ErrorMessage = "ID nhà xuất bản của sách không được để trống")]
        public int ID_Publisher { get; set; }

        [Column("ID_TheLoai")]
        [Required]
        public int ID_Genre { get; set; }

        [ForeignKey("ID_Language")]
        public virtual Language Language { get; set; }

        [ForeignKey("ID_Author")]
        public virtual Author Author { get; set; }

        [ForeignKey("ID_Publisher")]
        public virtual Publisher Publisher { get; set; }

        [ForeignKey("ID_Genre")]
        public virtual Genre Genre { get; set; }

        [Column("Anh")]
        public byte[] Image { get; set; }

        //public virtual ICollection<Book_Author> Book_Authors { get; set; }

        //public virtual ICollection<Book_Genre> Book_Genres { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}