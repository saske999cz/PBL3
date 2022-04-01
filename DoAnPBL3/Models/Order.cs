using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Hoa_Don")]
    public class Order
    {

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [Column("ID_HoaDon")]
        [StringLength(100)]
        [Required]
        public string ID_Order { get; set; }

        [Column("ngayTaoHoaDon")]
        [Required]
        public DateTime Date { get; set; }

        [Column("tongTien")]
        [Required]
        public int TotalPrice { get; set; }

        [Column("ID_KhachHang")]
        [StringLength(100)]
        [Required]
        public string ID_Customer { get; set; }
        [ForeignKey("ID_Customer")]
        public virtual Customer Customer { get; set; }

        [Column("ID_NhanVien")]
        [StringLength(100)]
        [Required]
        public string ID_Employee { get; set; }
        [ForeignKey("ID_Customer")]
        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}