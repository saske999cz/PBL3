using DoAnPBL3.Models;
using DoAnPBL3.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3
{
    public class InitialData : CreateDatabaseIfNotExists<BookStoreContext>
    {
        ImageConverter imageConverter = new ImageConverter();

        protected override void Seed(BookStoreContext context)
        {
            context.Accounts.AddRange(new Account[]
            {
                // Admin
                new Account {Username = "lehoanglong", Password = "lehoanglong", Email = "lelong.ll32@gmail.com", 
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "nguyenkhacthai", Password = "nguyenkhacthai", Email = "zed999cz@gmail.com",
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "daothuytrang", Password = "daothuytrang", Email = "thuytrangdao240402@gmail.com",
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_woman2, typeof(byte[]))},
                new Account {Username = "nguyentrongnghia", Password = "nguyentrongnghia", Email = "trongnghia161001@gmail.com",
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "lyvantanh", Password = "lyvantanh", Email = "lyvantanh1001@gmail.com",
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "ngoducquockhanh", Password = "ngoducquockhanh", Email = "ngoducquockhanh@gmail.com",
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "travanthien", Password = "travanthien", Email = "travanthien@gmail.com",
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "letronghoangminh", Password = "letronghoangminh", Email = "letronghoangminh@gmail.com", 
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "leviettungduong", Password = "leviettungduong", Email = "leviettungduong@gmail.com", 
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "nguyentrongsang", Password = "nguyentrongsang", Email = "nguyentrongsang@gmail.com", 
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                new Account {Username = "nguyenvanhoangnhan", Password = "nguyenvanhoangnhan", Email = "nguyenvanhoangnhan@gmail.com", 
                    Role = true, Avatar = (byte[])imageConverter.ConvertTo(Resources.administrator_man, typeof(byte[]))},
                // Employee
                new Account {Username = "phamtienhuu", Password = "phamtienhuu", Email = "phamtienhuu@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "nguyenbatuan", Password = "nguyenbatuan", Email = "nguyenbatuan@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "tranchinhhuy", Password = "tranchinhhuy", Email = "tranchinhhuy@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "dangvanphuocnguyen", Password = "dangvanphuocnguyen", Email = "dangvanphuocnguyen@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "nguyenquangkhai", Password = "nguyenquangkhai", Email = "nguyenquangkhai@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "phamhoangson", Password = "phamhoangson", Email = "phamhoangson@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "ngotandung", Password = "ngotandung", Email = "ngotandung@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "nguyenvankhoa", Password = "nguyenvankhoa", Email = "nguyenvankhoa@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "levanthanh", Password = "levanthanh", Email = "levanthanh@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.male_employee, typeof(byte[]))},
                new Account {Username = "trankhanhphuong", Password = "trankhanhphuong", Email = "trankhanhphuong@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.female_employee, typeof(byte[]))},
                new Account {Username = "lethihuyentrang", Password = "lethihuyentrang", Email = "lethihuyentrang@gmail.com", 
                    Role = false, Avatar = (byte[])imageConverter.ConvertTo(Resources.female_employee, typeof(byte[]))},
            });

            context.Admins.AddRange(new Admin[]
            {
                new Admin {ID_Admin = "AD0001", FullNameAdmin = "Lê Hoàng Long", Email = "lelong.ll32@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000001", ID_Card = "201800001", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "lehoanglong"},

                new Admin {ID_Admin = "AD0002", FullNameAdmin = "Nguyễn Khắc Thái", Email = "nguyenkhacthai@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000002", ID_Card = "201800002", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyenkhacthai"},

                new Admin {ID_Admin = "AD0003", FullNameAdmin = "Đào Thủy Trang", Email = "daothuytrang@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nữ", Phone = "0905000003", ID_Card = "201800003", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "daothuytrang"},

                new Admin {ID_Admin = "AD0004", FullNameAdmin = "Lý Văn Tánh", Email = "lyvantanh@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000001", ID_Card = "201800004", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "lyvantanh"},

                new Admin {ID_Admin = "AD0005", FullNameAdmin = "Ngô Đức Quốc Khánh", Email = "ngoducquockhanh@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000004", ID_Card = "201800005", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "ngoducquockhanh"},

                new Admin {ID_Admin = "AD0006", FullNameAdmin = "Trà Văn Thiên", Email = "travanthien@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000005", ID_Card = "201800006", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "travanthien"},

                new Admin {ID_Admin = "AD0007", FullNameAdmin = "Lê Trọng Hoàng Minh", Email = "letronghoangminh@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000006", ID_Card = "201800007", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "letronghoangminh"},

                new Admin {ID_Admin = "AD0008", FullNameAdmin = "Lê Viết Tùng Dương", Email = "leviettungduong@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000007", ID_Card = "201800008", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "leviettungduong"},

                new Admin {ID_Admin = "AD0009", FullNameAdmin = "Nguyễn Trọng Sang", Email = "nguyentrongsang@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000008", ID_Card = "201800009", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyentrongsang"},

                new Admin {ID_Admin = "AD0010", FullNameAdmin = "Nguyễn Văn Hoàng Nhân", Email = "nguyenvanhoangnhan@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000009", ID_Card = "201800010", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyenvanhoangnhan"},
            });

            context.Employees.AddRange(new Employee[]
            {
                new Employee {ID_Employee = "E0001", FullNameEmployee = "Phạm Tiến Hữu", Email = "phamtienhuu@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000001", Id_Card = "201800001", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "phamtienhuu"},

                new Employee {ID_Employee = "E0002", FullNameEmployee = "Nguyễn Bá Tuấn", Email = "nguyenbatuan@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000002", Id_Card = "201800002", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyenbatuan"},

                new Employee {ID_Employee = "E0003", FullNameEmployee = "Trần Chính Huy", Email = "tranchinhhuy@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000003", Id_Card = "201800003", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "tranchinhhuy"},

                new Employee {ID_Employee = "E0004", FullNameEmployee = "Nguyễn Quang Khải", Email = "nguyenquankhai@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000004", Id_Card = "201800004", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyenquangkhai"},

                new Employee {ID_Employee = "E0005", FullNameEmployee = "Phạm Hoàng Sơn", Email = "phamhoangson@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000005", Id_Card = "201800005", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "phamhoangson"},

                new Employee {ID_Employee = "E0006", FullNameEmployee = "Ngô Tấn Dũng", Email = "ngotandung@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000006", Id_Card = "201800006", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "ngotandung"},

                new Employee {ID_Employee = "E0007", FullNameEmployee = "Nguyễn Văn Khoa", Email = "nguyenvankhoa@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000007", Id_Card = "201800007", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyenvankhoa"},

                new Employee {ID_Employee = "E0008", FullNameEmployee = "Lê Văn Thành", Email = "levanthanh@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nam", Phone = "0905000008", Id_Card = "201800008", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "levanthanh"},

                new Employee {ID_Employee = "E0009", FullNameEmployee = "Trần Khánh Phương", Email = "trankhanhphuong@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nữ", Phone = "0905000009", Id_Card = "201800009", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "trankhanhphuong"},

                new Employee {ID_Employee = "E0010", FullNameEmployee = "Lê Thị Huyền Trang", Email = "lethihuyentrang@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01),
                    Gender = "Nữ", Phone = "0905000010", Id_Card = "201800010", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "lethihuyentrang"},
            });

            //context.Authors.AddRange(new Author[]
            //{
            //    new Author {ID_Author = 1, FullNameAuthor = "Nguyễn Minh Nhật", Email = "nguyenminhnhat@gmail.com"},
            //    new Author {ID_Author = 2, FullNameAuthor = "Gào (Vũ Phương Thanh)", Email = "gao@gmail.com"},
            //    new Author {ID_Author = 3, FullNameAuthor = "Hamlet Trương (Lê Văn Trương)", Email = "hamlettruong@gmail.com"},
            //    new Author {ID_Author = 4, FullNameAuthor = "Iris Cao", Email = "iriscao@gmail.com"},
            //    new Author {ID_Author = 5, FullNameAuthor = "Kawi Hồng Phương", Email = "kawihongphuong@gmail.com"},
            //    new Author {ID_Author = 6, FullNameAuthor = "Sơn Paris (Nguyễn Ngọc Sơn)", Email = "sonparis@gmail.com"},
            //    new Author {ID_Author = 7, FullNameAuthor = "Nguyễn Ngọc Thạch", Email = "nguyenngocthach@gmail.com"},
            //    new Author {ID_Author = 8, FullNameAuthor = "Anh Khang", Email = "anhkhang@gmail.com"},
            //    new Author {ID_Author = 9, FullNameAuthor = "Phan Ý Yên", Email = "phanyyen@gmail.com"},
            //});

            context.Languages.AddRange(new Language[]
            {
                new Language {ID_Language = 1, NameLanguage = "Tiếng Việt"},
                new Language {ID_Language = 2, NameLanguage = "Tiếng Anh"},
                new Language {ID_Language = 3, NameLanguage = "Tiếng Nhật"},
                new Language {ID_Language = 4, NameLanguage = "Tiếng Hàn"},
                new Language {ID_Language = 5, NameLanguage = "Tiếng Trung"},
                new Language {ID_Language = 6, NameLanguage = "Song ngữ Việt Anh"},
                new Language {ID_Language = 7, NameLanguage = "Song ngữ Việt Nhật"},
                new Language {ID_Language = 8, NameLanguage = "Song ngữ Việt Hàn"},
                new Language {ID_Language = 9, NameLanguage = "Song ngữ Việt Trung"},
            });

            context.Publishers.AddRange(new Publisher[]
            {
                new Publisher {ID_Publisher = 1, NamePublisher = "Nhà xuất bản Kim Đồng",
                    Email = "cskh_online@nxbkimdong.com.vn", PhoneContact = "(+84) 1900571595"},
                new Publisher {ID_Publisher = 2, NamePublisher = "Nhà xuất bản Trẻ",
                    Email = "hopthubandoc@nxbtre.com.vn", PhoneContact = "(028) 39316289 - 39316211 - 39317849"},
                new Publisher {ID_Publisher = 3, NamePublisher = "Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh",
                    Email = "nstonghop@gmail.com", PhoneContact = "(028) 3825 6804 - 3825 6713 - 3829 6764"},
                new Publisher {ID_Publisher = 4, NamePublisher = "Nhà xuất bản chính trị quốc gia sự thật",
                    Email = "suthat@nxbctqg.vn", PhoneContact = "024 3822 1633"},
                new Publisher {ID_Publisher = 5, NamePublisher = "Nhà xuất bản giáo dục",
                    Email = "nxbgd@gmail.com", PhoneContact = "024 3822 0801"},
                new Publisher {ID_Publisher = 6, NamePublisher = "Nhà xuất bản Hội Nhà văn",
                    Email = "nxbhoinhavan65@gmail.com", PhoneContact = "024.38222135"},
                new Publisher {ID_Publisher = 7, NamePublisher = "Nhà xuất bản Tư pháp",
                    Email = "nxbtp@moj.gov.vn", PhoneContact = "024. 6263 2079"},
                new Publisher {ID_Publisher = 8, NamePublisher = "Nhà xuất bản Thông tin và Truyền thông",
                    Email = "nxb.tttt@mic.gov.vn", PhoneContact = "0243 577 2145"},
                new Publisher {ID_Publisher = 9, NamePublisher = "Nhà xuất bản lao động",
                    Email = "nxblaodong@yahoo.com", PhoneContact = "024 3851 5380"},
                new Publisher {ID_Publisher = 10, NamePublisher = "Nhà xuất bản giao thông vận tải",
                    Email = "nxbgtvt@fpt.vn", PhoneContact = "024 3942 3346"},
                new Publisher {ID_Publisher = 11, NamePublisher = "Nhà xuất bản Đại học Quốc Gia Hà Nội",
                    Email = "024 3971 4896", PhoneContact = "nxb@vnu.edu.vn"},
            });

            context.Genres.AddRange(new Genre[]
            {
                new Genre {ID_Genre = 1, NameGenre = "Chính trị - Pháp luật"},
                new Genre {ID_Genre = 2, NameGenre = "Khoa học công nghệ - Kinh tế"},
                new Genre {ID_Genre = 3, NameGenre = "Văn học nghệ thuật"},
                new Genre {ID_Genre = 4, NameGenre = "Văn hóa xã hội - Lịch sử"},
                new Genre {ID_Genre = 5, NameGenre = "Giáo trình"},
                new Genre {ID_Genre = 6, NameGenre = "Truyện - Tiểu thuyết"},
                new Genre {ID_Genre = 7, NameGenre = "Tâm lý - Tâm linh - Tôn giáo"},
                new Genre {ID_Genre = 8, NameGenre = "Thiếu nhi"},
            });
        }
    }
}
