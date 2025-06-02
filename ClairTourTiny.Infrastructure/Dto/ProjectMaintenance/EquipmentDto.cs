using System.ComponentModel.DataAnnotations.Schema;

public class EquipmentDto
{
    [Column("entityno")]
    public string Entityno { get; set; } = string.Empty;

    [Column("seqno")]
    public int Seqno { get; set; }

    [Column("PartDescription")]
    public string PartDescription { get; set; } = string.Empty;

    [Column("partno")]
    public string Partno { get; set; } = string.Empty;

    [Column("StartDate")]
    public DateTime StartDate { get; set; }

    [Column("EndDate")]
    public DateTime EndDate { get; set; }

    [Column("UnitPrice")]
    public decimal UnitPrice { get; set; }

    [Column("Quantity")]
    public int Quantity { get; set; }

    [Column("mfg_no")]
    public string MfgNo { get; set; } = string.Empty;

    [Column("Notes")]
    public string Notes { get; set; } = string.Empty;

    [Column("Bottleneck")]
    public int? Bottleneck { get; set; }

    [Column("CheckedOut")]
    public int CheckedOut { get; set; }

    [Column("markup")]
    public double Markup { get; set; }

    [Column("QuantityToSubhire")]
    public int? QuantityToSubhire { get; set; }

    [Column("Category")]
    public string Category { get; set; } = string.Empty;

    [Column("NoteInternal")]
    public string NoteInternal { get; set; } = string.Empty;

    [Column("PriceLevelValue")]
    public double? PriceLevelValue { get; set; }

    [Column("totmatcost4")]
    public double Totmatcost4 { get; set; }

    [Column("matrixcd")]
    public string? MatrixCd { get; set; }
}
