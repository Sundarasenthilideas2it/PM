public class ProjectEquipmentSubhireModel
{
    public string EntityNo { get; set; } = string.Empty;
    public string PartNo { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string? VendorNo { get; set; }
    public string? SiteNo { get; set; }
    public string VendorName { get; set; } = string.Empty;
    public string? PONumber { get; set; }
    public decimal Rate { get; set; }
    public string RateType { get; set; } = string.Empty;
    public double BillableDays { get; set; }
    public decimal DeliveryRate { get; set; }
    public decimal ReturnRate { get; set; }
    public decimal Total { get; set; }
    public string? InvoiceNo { get; set; }
    public string? StatusCode { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public int LineNo { get; set; }
    public DateOnly ShopReceiptDate { get; set; }
    public DateOnly ShopReturnDate { get; set; }
}
