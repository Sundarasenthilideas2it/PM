namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class ProjectNote
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Entityno { get; set; } = null!;
    public string Notes { get; set; } = null!;
} 