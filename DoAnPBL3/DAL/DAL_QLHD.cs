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
    }
}
