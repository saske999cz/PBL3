using DoAnPBL3.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace DoAnPBL3
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("name=BookStoreContext")
        {
            Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<BookStoreContext>(new InitialData());
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(employee => new { employee.Phone, employee.Id_Card })
                .IsUnique(true);
            modelBuilder.Entity<Admin>()
                .HasIndex(admin => new { admin.Phone, admin.ID_Card })
                .IsUnique(true);
            modelBuilder.Entity<Customer>()
                .HasIndex(customer => customer.Phone)
                .IsUnique();
            modelBuilder.Entity<Employee>()
                .MapToStoredProcedures(s =>
                    s.Insert(i => i.HasName("Employee_Insert", "dbo")
                                   .Parameter(e => e.ID_Employee, "ID_NhanVien")
                                   .Parameter(e => e.FullNameEmployee, "HoVaTen")
                                   .Parameter(e => e.Email, "Email")
                                   .Parameter(e => e.DateOfBirth, "NgaySinh")
                                   .Parameter(e => e.StartDate, "NgayBatDau")
                                   .Parameter(e => e.Gender, "GioiTinh")
                                   .Parameter(e => e.Phone, "SDT")
                                   .Parameter(e => e.Id_Card, "CMND")
                                   .Parameter(e => e.Address, "DiaChi")
                                   .Parameter(e => e.Avatar, "Anh")
                                   .Parameter(e => e.AccountUsername, "TaiKhoanDangNhap"))
                     .Update(u => u.HasName("Employee_Update", "dbo")
                                   .Parameter(e => e.ID_Employee, "ID_NhanVien")
                                   .Parameter(e => e.FullNameEmployee, "HoVaTen")
                                   .Parameter(e => e.Email, "Email")
                                   .Parameter(e => e.DateOfBirth, "NgaySinh")
                                   .Parameter(e => e.StartDate, "NgayBatDau")
                                   .Parameter(e => e.Gender, "GioiTinh")
                                   .Parameter(e => e.Phone, "SDT")
                                   .Parameter(e => e.Id_Card, "CMND")
                                   .Parameter(e => e.Address, "DiaChi")
                                   .Parameter(e => e.Avatar, "Anh")
                                   .Parameter(e => e.AccountUsername, "TaiKhoanDangNhap"))
                     .Delete(d => d.HasName("Employee_Delete", "dbo")
                                   .Parameter(e => e.ID_Employee, "ID_NhanVien"))
               );
        }
    }
}