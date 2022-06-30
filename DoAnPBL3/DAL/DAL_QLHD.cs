using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    // Quản lý hóa đơn
    class DAL_QLHD
    {
        private static DAL_QLHD _Instance;
        public static DAL_QLHD Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLHD();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLHD()
        {

        }

        public List<Order> GetListOrderByIDCustomer(string ID_Customer)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Orders
                    .Where(order => order.ID_Customer == ID_Customer)
                    .Select(order => order)
                    .ToList();
            }
        }

        public List<Order> GetListOrderByEmployee(string nameEmployee, string ID_Customer)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Order> listOrders = (from order in db.Orders
                                          join employee in db.Employees on order.ID_Employee equals employee.ID_Employee
                                          where employee.FullNameEmployee.Contains(nameEmployee)
                                          where order.ID_Customer == ID_Customer
                                          select order).ToList();
                if (listOrders.Count > 0)
                    return listOrders;
                else
                    return null;
            }
        }

        public List<OrderDetail> GetOrderDetailsByIDOrder(string ID_Order)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.OrderDetails
                    .Where(orderDetail => orderDetail.ID_Order == ID_Order)
                    .Select(orderDetail => orderDetail)
                    .ToList();
            }
        }

        public Order GetOrderByID(string ID_Order)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Orders
                    .Where(order => order.ID_Order == ID_Order)
                    .Select(order => order)
                    .FirstOrDefault();
            }
        }

        public int GetNumberTotalOrderByIDCustomer(string ID_Customer)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Orders
                        .Where(customer => customer.ID_Customer == ID_Customer)
                        .Select(orderInfo => new
                        {
                            orderInfo.ID_Order,
                            orderInfo.OrderDate,
                            orderInfo.TotalPrice,
                            orderInfo.ID_Employee,
                        })
                        .ToList()
                        .Count();
            }
        }

        public int GetNumberTotalPriceByIDCustomer(string ID_Customer)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Orders
                        .Where(order => order.ID_Customer == ID_Customer)
                        .GroupBy(order => order.ID_Customer == ID_Customer)
                        .Select(orderInfo => new
                        {
                            TotalPrice = orderInfo.Sum(o => o.TotalPrice)
                        })
                        .FirstOrDefault()
                        .TotalPrice;
            }
        }

        public int GetTotalQuantity(string ID_Order)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.OrderDetails
                        .Where(orderDetail => orderDetail.ID_Order == ID_Order)
                        .GroupBy(orderDetail => orderDetail.ID_Order)
                        .Select(orderDetail => new
                        {
                            Quantity = orderDetail.Sum(o => o.Quantity)
                        })
                        .FirstOrDefault()
                        .Quantity;
            }
        }

        public int GetTotalAmount(string ID_Order)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.OrderDetails
                        .Where(orderDetail => orderDetail.ID_Order == ID_Order)
                        .GroupBy(orderDetail => orderDetail.ID_Order)
                        .Select(orderDetail => new
                        {
                            Price = orderDetail.Sum(o => o.TotalAmount)
                        })
                        .FirstOrDefault()
                        .Price;
            }
        }

        public string GetLastID()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Orders
                        .OrderBy(order => order.ID_Order)
                        .Select(order => order.ID_Order)
                        .ToList()
                        .LastOrDefault();
            }
        }

        public bool AddOrder(Order order)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                db.Orders.Add(order);
                int result = db.SaveChanges();
                return result > 0;
            }
        }

        public bool AddOrderDetail(OrderDetail orderDetail)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                db.OrderDetails.Add(orderDetail);
                int result = db.SaveChanges();
                return result > 0;
            }
        }
    }
}
