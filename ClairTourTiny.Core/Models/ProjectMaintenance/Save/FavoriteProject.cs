namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class FavoriteProject
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Username { get; set; } = null!;
    public string Entityno { get; set; } = null!;
} 