using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EquipmentSubhiresA
{
    public string? Entityno { get; set; }

    public string? Partno { get; set; }

    public int? Quantity { get; set; }

    public string? Vendno { get; set; }

    public string? Siteno { get; set; }

    public string? VendorName { get; set; }

    public string? Ponumber { get; set; }

    public decimal? Rate { get; set; }

    public string? RateType { get; set; }

    public decimal? DeliveryRate { get; set; }

    public decimal? ReturnRate { get; set; }

    public decimal? Total { get; set; }

    public string? InvoiceNo { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? LineNo { get; set; }

    public string? StatusCode { get; set; }

    public DateOnly? ShopReceiptDate { get; set; }

    public DateOnly? ShopReturnDate { get; set; }

    public double? Billabledays { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
