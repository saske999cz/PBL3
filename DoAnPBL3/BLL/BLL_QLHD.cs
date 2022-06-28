using DoAnPBL3.DAL;
using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    // Quản lý hóa đơn
    class BLL_QLHD
    {
        private static BLL_QLHD _Instance;
        public static BLL_QLHD Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLHD();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLHD()
        {

        }

        public List<Order> GetOrdersByIDCustomer(string ID_Customer)
        {
            return DAL_QLHD.Instance.GetListOrderByIDCustomer(ID_Customer);
        }

        public int GetNumberTotalOrderByIDCustomer(string ID_Customer)
        {
            return DAL_QLHD.Instance.GetNumberTotalOrderByIDCustomer(ID_Customer);
        }
        
        public int GetNumberTotalPriceByIDCustomer(string ID_Customer)
        {
            return DAL_QLHD.Instance.GetNumberTotalPriceByIDCustomer(ID_Customer);
        }

        public List<OrderDetail> GetOrderDetailsByIDOrder(string ID_Order)
        {
            return DAL_QLHD.Instance.GetOrderDetailsByIDOrder(ID_Order);
        }

        public int GetTotalQuantity(string ID_Order)
        {
            return DAL_QLHD.Instance.GetTotalQuantity(ID_Order);
        }

        public int GetTotalAmount(string ID_Order)
        {
            return DAL_QLHD.Instance.GetTotalAmount(ID_Order);
        }
    }
}
