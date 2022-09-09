using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tour
{   
    class ChuyenDAL
    {
        DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter da;


        public ChuyenDAL()
        {
        }
        public bool LoadComboBox(ComboBox cb)
        {

            string query = "Select MaTuyen, TenTuyen From Tuyen";

            return true;
        }
        public dynamic getAllChuyen()
        {
            return null;
        }

        public tblChuyen getChuyen(Guid id)
        {
            return null;
        }

        public bool InsertChuyen(tblChuyen route)
        {
            return true;
        }
        public bool UpdateChuyen(tblChuyen route)
        {
            return true;
        }
        public bool DeleteChuyen(tblChuyen route)
        {
            string query = "Delete from ChuyenDuLich where MaChuyen=" + route.MaChuyen;
            return true;
        }
        public dynamic FindChuyen(string routeID)
        {
            return null;
        }
    }
}
