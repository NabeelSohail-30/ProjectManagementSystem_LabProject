using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public interface IProjectDetailsRepo
    {
        int Add(ProjectDetailsModel project);
        int Update(int Id, ProjectDetailsModel project);
        ProjectDetailsModel Find(int Id);
    }
}
