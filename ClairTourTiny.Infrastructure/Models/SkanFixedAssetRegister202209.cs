using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SkanFixedAssetRegister202209
{
    public string? AudioNonAudio { get; set; }

    public string? Group { get; set; }

    public string? ItemName { get; set; }

    public string? SupplierManufacturer { get; set; }

    public string? BarCode { get; set; }

    public string? Serial { get; set; }

    public string? Quantity { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public double? Cost { get; set; }

    public int? Fy { get; set; }

    public DateTime? PurchaseDateForDepreciation { get; set; }

    public double? DepreciationRate25 { get; set; }

    public double? TotalDepreciationTo310722 { get; set; }

    public double? NbvAt310722 { get; set; }

    public double? DeprAug22 { get; set; }

    public double? DeprSep22 { get; set; }

    public double? NbvAt300922 { get; set; }

    public string? Notes { get; set; }

    public string? InvNo { get; set; }

    public DateTime? InvDate { get; set; }

    public double? InvValue { get; set; }

    public DateTime? PoDeliveryDate { get; set; }

    public string? PurchaseOrderNo { get; set; }

    public string? SupplierName { get; set; }
}
