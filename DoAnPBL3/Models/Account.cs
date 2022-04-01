using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.Models
{
    [Table("Tai_Khoan")]
    public class Account
    {

        public Account()
        {
            AdminAccounts = new HashSet<Admin>();
            EmployeeAccounts = new HashSet<Employee>();
            CustomerAccounts = new HashSet<Customer>();
        }

        [Key]
        [Column("TenDangNhap")]
        [StringLength(255)]
        [Required]
        public string Username { get; set; }

        [Column("matKhau")]
        [StringLength(255)]
        [Required]
        public string Password { get; set; }

        [Column("quyen")]
        [StringLength(255)]
        [Required]
        public string Role { get; set; }

        public virtual ICollection<Admin> AdminAccounts { get; set; }
        public virtual ICollection<Employee> EmployeeAccounts { get; set; }
        public virtual ICollection<Customer> CustomerAccounts { get; set; }
    }
}