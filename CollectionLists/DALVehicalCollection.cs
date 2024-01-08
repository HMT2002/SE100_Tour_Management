using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;
namespace Tour.CollectionLists
{

    public class DALVehicalModel
    {
        public DALVehicalModel() { }
        string ten;
        public string TEN { get => ten; set => ten = value; }
        string loai;
        public string LOAI { get => loai; set => loai = value; }
        string id;
        public string ID { get => id; set => id = value; }
        byte[] banner;
        public byte[] BANNER { get => banner; set => banner = value; }
        string idtinh;
        public string IDTINH { get => idtinh; set => idtinh  = value; }
        bool isDelete;
        public bool IsDeleted { get => isDelete; set => isDelete = value; }
        decimal gia;
        public decimal GIA { get => gia; set => gia = value; }
    }
    public class DALVehicalCollection
    {
        public List<PHUONGTIEN> AllVehicalList()
        {
            return DataProvider.Ins.DB.PHUONGTIENs.Where(t => t.IsDeleted == false).Select(t => t).ToList();
        }
    }
}
