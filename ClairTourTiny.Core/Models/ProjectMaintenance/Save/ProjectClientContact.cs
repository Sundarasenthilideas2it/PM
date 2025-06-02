namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class ProjectClientContact
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Entityno { get; set; } = null!;
    public int IdContactCategory { get; set; }
    public string ContactNo { get; set; } = null!;
} 