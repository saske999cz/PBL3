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
    }
}
