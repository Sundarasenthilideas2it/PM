namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class ProjectBillingPeriod
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string BidEntityno { get; set; } = null!;
    public short Periodno { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string PeriodTitle { get; set; } = null!;
    public bool IsActive { get; set; }
    public bool ShowOnQuoteReport { get; set; }
    public int? DisplayOrder { get; set; }
} 