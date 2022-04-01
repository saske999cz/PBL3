using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Nha_Xuat_Ban")]
    public class Publisher
    {

        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [Column("ID_NhaXuatBan")]
        [StringLength(100)]
        [Required]
        public string ID_Publisher { get; set; }

        [Column("tenNhaXuatBan")]
        [StringLength(255)]
        [Required]
        public string NamePublisher { get; set; }

        [StringLength(255)]
        [Required]
        public string Email { get; set; }

        [Column("SDT")]
        [StringLength(255)]
        [Required]
        public string PhoneContact { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}