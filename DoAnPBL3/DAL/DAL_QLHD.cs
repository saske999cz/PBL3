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
            using (BookStoreContext context = new BookStoreContext())
            {
                return context.Orders
                    .Where(order => order.ID_Customer == ID_Customer)
                    .Select(order => order)
                    .ToList();
            }
        }

        public List<OrderDetail> GetOrderDetailsByIDOrder(string ID_Order)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                return context.OrderDetails
                    .Where(orderDetail => orderDetail.ID_Order == ID_Order)
                    .Select(orderDetail => orderDetail)
                    .ToList();
            }
        }

        public int GetNumberTotalOrderByIDCustomer(string ID_Customer)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                return context.Orders
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
            using (BookStoreContext context = new BookStoreContext())
            {
                return context.Orders
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
            using (BookStoreContext context = new BookStoreContext())
            {
                return context.OrderDetails
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
            using (BookStoreContext context = new BookStoreContext())
            {
                return context.OrderDetails
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
    }
}
