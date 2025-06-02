namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class BidRevenue
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Entityno { get; set; } = null!;
    public int Seqno { get; set; }
    public string Notes { get; set; } = null!;
    public DateTime Startdate { get; set; }
    public DateTime Enddate { get; set; }
    public double Amount { get; set; }
} 