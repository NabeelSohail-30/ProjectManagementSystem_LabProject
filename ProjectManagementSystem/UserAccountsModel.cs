using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class UserAccountsModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string LoginRole { get; set; }
        public DateTime LoginDateTime { get; set; }
    }
}
