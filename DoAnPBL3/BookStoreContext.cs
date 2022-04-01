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
            Database.SetInitializer<BookStoreContext>(new CreateDatabaseIfNotExists<BookStoreContext>());
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> AdminAccounts { get; set; }
        public virtual DbSet<Employee> EmployeeAccounts { get; set; }
        public virtual DbSet<Customer> CustomerAccounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}