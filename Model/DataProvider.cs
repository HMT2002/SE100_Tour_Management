using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Model
{
    public class DataProvider
    {
        private static DataProvider _ins;

        public static DataProvider Ins { get { if (_ins == null) _ins = new DataProvider(); return _ins; } set => _ins = value; }

        public QL_TOUR_DU_LICHEntities DB { get => db; set => db = value; }

        private QL_TOUR_DU_LICHEntities db;

        public DataProvider()
        {
            DB = new QL_TOUR_DU_LICHEntities();

        }
    }

    public class AppDbContextFactory
    {

        public AppDbContextFactory() { }
        private static AppDbContextFactory _ins;

        public static AppDbContextFactory Ins { get { if (_ins == null) _ins = new AppDbContextFactory(); return _ins; } set => _ins = value; }
        public QL_TOUR_DU_LICHEntities CreateDbContext()
        {
            DataProvider.Ins.DB.Database.CreateIfNotExists();
            return DataProvider.Ins.DB;
        }
    }
}
