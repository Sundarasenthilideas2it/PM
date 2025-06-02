using System.ComponentModel.DataAnnotations.Schema;

public class BidExpenseDto
{
    [Column("entityno")]
    public string EntityNo { get; set; } = string.Empty;

    [Column("seqno")]
    public int SeqNo { get; set; }

    [Column("expcd")]
    public string ExpenseCode { get; set; } = string.Empty;

    [Column("period_type")]
    public string PeriodType { get; set; } = string.Empty;

    [Column("notes")]
    public string Notes { get; set; } = string.Empty;

    [Column("item_cost")]
    public double ItemCost { get; set; }

    [Column("item_qty")]
    public int ItemQuantity { get; set; }

    [Column("category")]
    public string Category { get; set; } = string.Empty;
}
