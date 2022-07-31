using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public interface IClientDetailRepo
    {
        int Add(ClientDetailModel client);
    }
}
