namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class RfiModel
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Entityno { get; set; } = null!;
    public int Seqno { get; set; }
    public string? InvEntityno { get; set; }
    public string? Description { get; set; }
    public DateTime? Startdate { get; set; }
    public DateTime? Enddate { get; set; }
    public decimal? Rate { get; set; }
    public string? Ratetype { get; set; }
    public string? Note { get; set; }
    public string? AeApproved { get; set; }
    public string? AmApproved { get; set; }
    public string? Billschedule { get; set; }
    public string? Acctcd { get; set; }
    public int? Numdays { get; set; }
    public string? RevenueCompany { get; set; }
    public double? Total { get; set; }
    public bool IsManualAdjustment { get; set; }
} 