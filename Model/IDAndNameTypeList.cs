using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Model
{
    public class IDAndNameTypeList
    {
        private static IDAndNameTypeList instance;

        public static IDAndNameTypeList Instance
        {
            get { if (instance == null) instance = new IDAndNameTypeList(); return IDAndNameTypeList.instance; }
            private set { IDAndNameTypeList.instance = value; }
        }
        private IDAndNameTypeList()
        {

        }

        public List<IDAndNameType> ListKhachSan(string ID="")
        {
            return (from ks in DataProvider.Ins.DB.KHACHSANs
                    join tb_belong in DataProvider.Ins.DB.tb_KHACHSAN on ks.ID equals tb_belong.IDKHACHSAN
                    where tb_belong.IDDOAN == ID && tb_belong.IsDeleted == false
                    select new IDAndNameType
                    {
                        ID = ks.ID,
                        TEN = ks.TEN,
                    }).ToList();
        }

        public List<IDAndNameType> ListPhuongTien(string ID = "")
        {
            return (from pt in DataProvider.Ins.DB.PHUONGTIENs
                    join tb_belong in DataProvider.Ins.DB.tb_PHUONGTIEN on pt.ID equals tb_belong.IDPHUONGTIEN
                    where tb_belong.IDDOAN == ID && tb_belong.IsDeleted == false
                    select new IDAndNameType
                    {
                        ID = pt.ID,
                        TEN = pt.TEN,
                    }).ToList();
        }

        public List<IDAndNameType> ListKhachHang(string ID = "")
        {
            return (from ve in DataProvider.Ins.DB.VEs
                    where ve.IDDOAN == ID && ve.IsDeleted == false
                    select new IDAndNameType
                    {
                        ID = ve.KHACHHANG.ID,
                        TEN = ve.KHACHHANG.TENKH,
                    }).ToList();
        }

        public List<IDAndNameType> ListTourStatistic(int Year = 0)
        {
            return (from tour in DataProvider.Ins.DB.TOURs
                    join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                    join ve in DataProvider.Ins.DB.VEs on doan.ID equals ve.IDDOAN
                    where tour.IsDeleted == false && ve.IsDeleted == false && doan.IsDeleted == false && ve.NGAYMUA.Value.Year == Year

                    group tour by new { tour.ID, tour.TEN, ve.NGAYMUA.Value.Year } into g

                    select new IDAndNameType
                    {
                        ID = g.Key.ID,
                        TEN = g.Key.TEN,
                    }).Distinct().ToList();
        }
    }
}
