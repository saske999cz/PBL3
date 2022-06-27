using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    class DAL_Login
    {
        private static DAL_Login _Instance;
        public static DAL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Login();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_Login()
        {

        }

        public string CheckLogin(Account account)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                var acc = db.Accounts
                    .Where(a => a.Username == account.Username)
                    .Where(a => a.Password == account.Password)
                    .Where(a => a.Role == account.Role)
                    .ToList()
                    .FirstOrDefault();
                if (acc == null)
                    return "Đăng nhập thất bại";
                else
                    return "Đăng nhập thành công";
            }
        }

        public string GetNameStaff(Account account)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                var nameEmployee = db.Accounts
                    .Where(acc => acc.Username == account.Username)
                    .Join(
                        db.Employees,
                        acc => acc.Username,
                        emp => emp.AccountUsername,
                        (acc, emp) => new
                        {
                            emp.FullNameEmployee,
                        })
                    .ToList()
                    .FirstOrDefault();
                if (nameEmployee == null)
                    return null;
                else
                    return nameEmployee.FullNameEmployee;
            }
        }
    }
}
