using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using StringLengthAttribute = System.ComponentModel.DataAnnotations.StringLengthAttribute;

namespace DoAnPBL3.Models
{
    [Table("The_Loai")]
    public class Genre
    {

        public Genre()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [Column("ID_TheLoai")]
        [AutoIncrement]
        [Required]
        public int ID_Genre { get; set; }

        [Column("tenTheLoai")]
        [StringLength(255)]
        [Required]
        public string NameGenre { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}