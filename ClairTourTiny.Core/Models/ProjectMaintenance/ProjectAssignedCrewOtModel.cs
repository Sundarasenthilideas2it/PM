using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectAssignedCrewOtModel
    {
        public string EmpNo { get; set; } = string.Empty;
        public string EntityNo { get; set; } = string.Empty;
        public string JobType { get; set; } = string.Empty;
        public DateTime FromDate { get; set; }
        public string RateType { get; set; } = string.Empty;
        public double Hours { get; set; }
    }
}
