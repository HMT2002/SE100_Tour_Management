using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    public class DataConnection
    {
        public static DataConnection Ins { 
            get {
                if (_Ins == null)
                    _Ins = new DataConnection();
                return _Ins;
            } 
            set
            {
                _Ins = value;
            }
        }
        private static DataConnection _Ins;


        private DataConnection()
        {

        }

            
    }
}
