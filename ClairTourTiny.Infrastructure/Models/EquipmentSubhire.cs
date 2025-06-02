using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EquipmentSubhire
{
    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int Quantity { get; set; }

    public string? Vendno { get; set; }

    public string? Siteno { get; set; }

    public string VendorName { get; set; } = null!;

    public string? Ponumber { get; set; }

    public decimal Rate { get; set; }

    public string RateType { get; set; } = null!;

    public decimal DeliveryRate { get; set; }

    public decimal ReturnRate { get; set; }

    public decimal Total { get; set; }

    public string? InvoiceNo { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int LineNo { get; set; }

    public string? StatusCode { get; set; }

    public DateOnly ShopReceiptDate { get; set; }

    public DateOnly ShopReturnDate { get; set; }

    public double Billabledays { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;

    public virtual EquipmentSubhireStatus? StatusCodeNavigation { get; set; }
}
