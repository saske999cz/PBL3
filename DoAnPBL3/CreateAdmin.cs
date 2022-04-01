using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3
{
    public class CreateAdmin : CreateDatabaseIfNotExists<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            context.Accounts.AddRange(new Account[]
            {
                new Account {Username = "lehoanglong", Password = "lehoanglong", Email = "lelong.ll32@gmail.com", Role = "ADMIN"},
                new Account {Username = "nguyenkhacthai", Password = "nguyenkhacthai", Email = "zed999cz@gmail.com", Role = "ADMIN"},
                new Account {Username = "daothuytrang", Password = "daothuytrang", Email = "thuytrangdao240402@gmail.com", Role = "ADMIN"},
                new Account {Username = "nguyentrongnghia", Password = "nguyentrongnghia", Email = "trongnghia161001@gmail.com", Role = "ADMIN"},
            });
            context.AdminAccounts.AddRange(new Admin[]
            {
                new Admin {ID_Admin = "AD0001", NameAdmin = "Lê Hoàng Long", Email = "lelong.ll32@gmail.com", 
                    DateOfBirth = new DateTime(2002, 01, 14), Gender = "Nam", Phone = "0905395436", 
                    ID_Card = "201844993", Address = "Đà Nẵng", Avatar = new byte[] { }, UserName = "lehoanglong"},
                new Admin {ID_Admin = "AD0002", NameAdmin = "Nguyễn Khắc Thái", Email = "zed999cz@gmail.com", 
                    DateOfBirth = new DateTime(2001, 06, 26), Gender = "Nam", Phone = "0905395436", 
                    ID_Card = "201827591", Address = "Đà Nẵng", Avatar = new byte[] { }, UserName = "nguyenkhacthai"},
                new Admin {ID_Admin = "AD0003", NameAdmin = "Đào Thủy Trang", Email = "thuytrangdao240402@gmail.com", 
                    DateOfBirth = new DateTime(2002, 04, 24), Gender = "Nữ", Phone = "0905395436", 
                    ID_Card = "201873912", Address = "Ninh Bình", Avatar = new byte[] { }, UserName = "daothuytrang"},
                new Admin {ID_Admin = "AD0004", NameAdmin = "Nguyễn Trọng Nghĩa", Email = "trongnghia161001@gmail.com", 
                    DateOfBirth = new DateTime(2001, 10, 16), Gender = "Nam", Phone = "0905395436", 
                    ID_Card = "201803812", Address = "Quảng Nam", Avatar = new byte[] { }, UserName = "nguyentrongnghia"},
            });
        }
    }
}
