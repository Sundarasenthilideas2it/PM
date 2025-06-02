namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class ProjectEmployeeOvertimeRate
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Empno { get; set; } = null!;
    public string Entityno { get; set; } = null!;
    public string Jobtype { get; set; } = null!;
    public DateTime Fromdate { get; set; }
    public string RateType { get; set; } = null!;
    public double Hours { get; set; }
} 