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
            Books = new HashSet<Book>();
        }

        [Key]
        [Column("ID_TacGia")]
        [StringLength(100)]
        [Required]
        public string ID_Author { get; set; }

        [Column("hoVaTen")]
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        [Required]
        public string Email { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}