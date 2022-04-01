using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Khach_Hang")]
    public class Customer
    {

        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("ID_KhachHang")]
        [StringLength(100)]
        [Required]
        public string ID_Customer { get; set; }

        [Column("hoVaTen")]
        [StringLength(255)]
        [Required]
        public string NameAdmin { get; set; }

        [StringLength(255)]
        [Required]
        public string Email { get; set; }

        [Column("gioiTinh")]
        [StringLength(20)]
        [Required]
        public string Gender { get; set; }

        [Column("SDT")]
        [StringLength(20)]
        [Required]
        public string Phone { get; set; }

        [Column("diaChi")]
        [StringLength(255)]
        [Required]
        public string Address { get; set; }

        [Column("taiKhoanDangNhap")]
        [StringLength(255)]
        public string Username { get; set; }
        [ForeignKey("Username")]
        public virtual Account Account { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}