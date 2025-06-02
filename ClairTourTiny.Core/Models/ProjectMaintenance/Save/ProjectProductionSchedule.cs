namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class ProjectProductionSchedule
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Entityno { get; set; } = null!;
    public string EventType { get; set; } = null!;
    public DateTime? EndDate { get; set; }
    public int? VenueId { get; set; }
    public string? DestinationDetail { get; set; }
    public string? Note { get; set; }
    public DateTime StartDateOld { get; set; }
    public DateTime StartDateNew { get; set; }
    public DateTime? StartDate { get; set; }
} 