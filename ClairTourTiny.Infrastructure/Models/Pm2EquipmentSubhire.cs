using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pm2EquipmentSubhire
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int Quantity { get; set; }

    public string? Vendno { get; set; }

    public string? Siteno { get; set; }

    public string VendorName { get; set; } = null!;

    public string? Ponumber { get; set; }

    public double Rate { get; set; }

    public string RateType { get; set; } = null!;

    public double DeliveryRate { get; set; }

    public double ReturnRate { get; set; }

    public double Total { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int LineNo { get; set; }

    public string StatusCode { get; set; } = null!;

    public DateOnly ShopReceiptDate { get; set; }

    public DateOnly ShopReturnDate { get; set; }

    public double Billabledays { get; set; }
}
