namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class Equipment
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string? Entityno { get; set; }
    public string? PartnoOld { get; set; }
    public string? PartnoNew { get; set; }
    public int? Seqno { get; set; }
    public string? PartDescription { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? UnitPrice { get; set; }
    public double? Quantity { get; set; }
    public string? MfgNo { get; set; }
    public string? Notes { get; set; }
    public double? Pieces { get; set; }
    public double? Markup { get; set; }
    public double? QuantityToSubhire { get; set; }
    public string NoteInternal { get; set; } = null!;
    public double? PriceLevelValue { get; set; }
    public string? Matrixcd { get; set; }
} 