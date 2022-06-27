using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    // Quản lý doanh thu
    class DAL_QLDT
    {
        private static DAL_QLDT _Instance;
        public static DAL_QLDT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLDT();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLDT()
        {

        }
    }
}
