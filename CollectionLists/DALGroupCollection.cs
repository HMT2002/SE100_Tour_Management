using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;

namespace Tour.CollectionLists
{

    public class DALGroupModel
    {
        public DALGroupModel() { }
        string tendoan;
        string iddoan;
        DateTime ngaykhoihanh;
        DateTime ngayketthuc;

        public string TENDOAN { get => tendoan; set => tendoan = value; }
        public string IDDOAN { get => iddoan; set => iddoan = value; }
        public DateTime NGAYKHOIHANH { get => ngaykhoihanh; set => ngaykhoihanh = value; }
        public DateTime NGAYKETTHUC { get => ngayketthuc; set => ngayketthuc = value; }
    }
    public class DALGroupCollection
    {
        public DALGroupCollection() { }
        public List<DALGroupModel> AvailableGroupList(string idtour)
        {
            return (from tour in DataProvider.Ins.DB.TOURs
                    join doan in DataProvider.Ins.DB.DOANs on tour.ID equals doan.IDTOUR
                    where tour.ID == idtour && tour.IsDeleted == false && doan.IsDeleted == false
                    select new DALGroupModel
                    {
                        TENDOAN = doan.TEN,
                        IDDOAN = doan.ID,
                        NGAYKHOIHANH = (DateTime)doan.NGAYKHOIHANH,
                        NGAYKETTHUC = (DateTime)doan.NGAYKETTHUC
                    }
                                            ).ToList();
        }
    }
}
