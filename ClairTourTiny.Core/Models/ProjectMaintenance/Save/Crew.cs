namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class Crew
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Entityno { get; set; } = null!;
    public int Seqno { get; set; }
    public string JobtypeOld { get; set; } = null!;
    public string JobtypeNew { get; set; } = null!;
    public string Jobdesc { get; set; } = null!;
    public DateTime Fromdate { get; set; }
    public DateTime Todate { get; set; }
    public int CrewSize { get; set; }
    public double EstHours { get; set; }
    public double EstRate { get; set; }
    public decimal EstTotal { get; set; }
    public int EmplineNo { get; set; }
} 