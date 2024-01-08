using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;

namespace Tour.CollectionLists
{
    public class DALLocationCollection
    {
        public List<DIADIEM> AllLocationList()
        {
            return DataProvider.Ins.DB.DIADIEMs.Where(t => t.IsDeleted == false).Select(t => t).ToList();
        }
        public DbSet<DIADIEM> LocationContext()
        {
            return DataProvider.Ins.DB.DIADIEMs;
        }

    }
}
