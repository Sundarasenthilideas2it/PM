using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class CrewDto
    {
        [Column("entityno")]
        public string EntityNo { get; set; } = string.Empty;

        [Column("seqno")]
        public int SeqNo { get; set; }

        [Column("jobtype")]
        public string JobType { get; set; } = string.Empty;

        [Column("jobdesc")]
        public string JobDesc { get; set; } = string.Empty;

        [Column("fromdate")]
        public DateTime FromDate { get; set; }

        [Column("todate")]
        public DateTime ToDate { get; set; }

        [Column("crew_size")]
        public int CrewSize { get; set; }

        [Column("est_hours")]
        public double EstHours { get; set; }

        [Column("est_rate")]
        public double EstRate { get; set; }

        [Column("est_total")]
        public decimal EstTotal { get; set; }

        [Column("empline_no")]
        public int EmpLineNo { get; set; }
    }
}
