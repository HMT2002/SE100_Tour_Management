using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Model
{
    public class GroupDisplayType
    {
        public string ID { get; set; }
        public string TEN { get; set; }

        public Nullable<System.DateTime> NGAYKHOIHANH { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }

        public string CHITIETCHUONGTRINH { get; set; }

        public Nullable<decimal> GIA_TOUR { get; set; }

        public string TEN_TOUR { get; set; }

        public string ID_TOUR { get; set; }

        public string STATUS { get; set; }



    }
}
