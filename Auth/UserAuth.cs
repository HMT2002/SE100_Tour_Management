using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;

namespace Tour.Auth
{
    public interface UserAuth
    { 
        NHANVIEN GrantAccessToUser(string username, string password);
    }
}
