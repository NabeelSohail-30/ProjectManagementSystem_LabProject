using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    interface IUserAccountsRepo
    {
        UserAccountsModel Authenticate(string pUserName, string pUserPassword);
        int Update(int Id, UserAccountsModel user);
    }
}
