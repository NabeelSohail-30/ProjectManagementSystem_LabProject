using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class ProjectDetailsModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public int ProjectTypeId { get; set; }
        public string ProjectTools { get; set; }
        public int ClientId { get; set; }
        public string ProjectStartDateTime { get; set; }
        public string ProjectEndDateTime { get; set; }
        public int ProjectStatusId { get; set; }
        public string ProjectURL { get; set; }
        public double ProjectPrice { get; set; }
    }
}
