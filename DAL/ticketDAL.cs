using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    class ticketDAL
    {
        public bool Insert(tblTicket tk)
        {
            return true;
        }
        public bool Update(tblTicket tk)
        {
            return true;
        }

        public bool UpdateCustomerInTicket(Customer cus, Guid MaVe, Guid MaPhieu)
        {
            return true;
        }

        public bool Delete(tblTicket tk)
        {
            return true;
        }
    }
}
