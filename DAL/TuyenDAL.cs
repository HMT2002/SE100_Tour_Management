using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Tour
{
    class TuyenDAL
    {

        public TuyenDAL()
        {

        }
        public dynamic getAllTuyen()
        {
            string query = "Select MaTuyen, TenTuyen, XuatPhat, DiaDiem, ThoiGianToChuc, TenLoaiTuyen, MaLoaiTuyen from Tuyen";

            return null;
        }
        public bool InsertTuyen(tblTuyen route)
        {
            return true;
        }
        public bool UpdateTuyen(tblTuyen route)
        {
            return true;
        }
        public bool DeleteTuyen(tblTuyen route)
        {
            string query = "Delete from Tuyen where MaTuyen = " + route.MaTuyen;
            //DataConnection.Ins.session.Execute(query);
            return true;
        }
        public dynamic FindTuyen(string route)
        {
            string query = "Select MaTuyen, TenTuyen, XuatPhat, DiaDiem, ThoiGianToChuc, TenLoaiTuyen, MaLoaiTuyen from Tuyen where TenTuyen like '%" + route + "%'";
            return null;
        }
    }
}
