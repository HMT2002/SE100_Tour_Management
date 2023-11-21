using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;

namespace Tour.Auth
{
    public class UserAuthConcrete: UserAuth
    {
        private string username;
        private string password;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public UserAuthConcrete() { }


        public NHANVIEN GrantAccessToUser(string username, string password)
        {
            NHANVIEN curUser = DataProvider.Ins.DB.NHANVIENs.Where(x => (x.ACCOUNT.ACC == username && x.ACCOUNT.PASS == password && x.IsDeleted == false)).SingleOrDefault();
            return curUser;
        }


    }
}
