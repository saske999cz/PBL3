using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Tac_Gia")]
    public class Author
    {
        public Author()
        {

        }

        public Author(int id_author, string fullNameAuthor, string email)
        {
            ID_Author = id_author;
            FullNameAuthor = fullNameAuthor;
            Email = email;
        }

        [Key]
        [Column("ID_TacGia")]
        [Required(ErrorMessage = "ID của tác giả không được để trống")]
        public int ID_Author { get; set; }

        [Column("HoVaTen")]
        [StringLength(255)]
        [Required(ErrorMessage = "Họ và tên của tác giả không được để trống")]
        public string FullNameAuthor { get; set; }

        [StringLength(255)]
        public string Email { get; set; }
    }
}