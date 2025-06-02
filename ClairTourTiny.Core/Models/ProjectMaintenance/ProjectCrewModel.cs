namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectCrewModel
    {
        public string EntityNo { get; set; } = string.Empty;
        public int SeqNo { get; set; }
        public string JobType { get; set; } = string.Empty;
        public string JobDesc { get; set; } = string.Empty;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int CrewSize { get; set; }
        public double EstHours { get; set; }
        public double EstRate { get; set; }
        public decimal EstTotal { get; set; }
        public int EmpLineNo { get; set; }
    }
}
