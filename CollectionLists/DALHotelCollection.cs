using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;

namespace Tour.CollectionLists
{
    public class DALHotelCollection
    {
        public DALHotelCollection() { }


        public List<KHACHSAN> AllHotelList()
        {
            return DataProvider.Ins.DB.KHACHSANs.Where(t => t.IsDeleted == false).Select(t => t).ToList();
        }
    }
}
