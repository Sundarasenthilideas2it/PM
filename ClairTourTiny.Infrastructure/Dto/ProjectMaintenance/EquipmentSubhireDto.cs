using System.ComponentModel.DataAnnotations.Schema;

public class EquipmentSubhireDto
{
    [Column("entityno")]
    public string EntityNo { get; set; } = string.Empty;

    [Column("partno")]
    public string PartNo { get; set; } = string.Empty;

    [Column("Quantity")]
    public int Quantity { get; set; }

    [Column("vendno")]
    public string? VendorNo { get; set; }

    [Column("siteno")]
    public string? SiteNo { get; set; }

    [Column("VendorName")]
    public string VendorName { get; set; } = string.Empty;

    [Column("PONumber")]
    public string? PONumber { get; set; }

    [Column("Rate")]
    public decimal Rate { get; set; }

    [Column("RateType")]
    public string RateType { get; set; } = string.Empty;

    [Column("billabledays")]
    public double BillableDays { get; set; }

    [Column("DeliveryRate")]
    public decimal DeliveryRate { get; set; }

    [Column("ReturnRate")]
    public decimal ReturnRate { get; set; }

    [Column("Total")]
    public decimal Total { get; set; }

    [Column("InvoiceNo")]
    public string? InvoiceNo { get; set; }

    [Column("StatusCode")]
    public string? StatusCode { get; set; }

    [Column("StartDate")]
    public DateOnly StartDate { get; set; }

    [Column("EndDate")]
    public DateOnly EndDate { get; set; }

    [Column("line_no")]
    public int LineNo { get; set; }

    [Column("ShopReceiptDate")]
    public DateOnly ShopReceiptDate { get; set; }

    [Column("ShopReturnDate")]
    public DateOnly ShopReturnDate { get; set; }
}
