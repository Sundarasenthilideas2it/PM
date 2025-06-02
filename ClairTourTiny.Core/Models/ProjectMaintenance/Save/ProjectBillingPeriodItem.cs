namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class ProjectBillingPeriodItem
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string BidEntityno { get; set; } = null!;
    public short Periodno { get; set; }
    public short Itemno { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? AdjustedWeekly { get; set; }
    public int IsActive { get; set; }
    public double? BillingDays { get; set; }
    public double ActualDailyRate { get; set; }
} 