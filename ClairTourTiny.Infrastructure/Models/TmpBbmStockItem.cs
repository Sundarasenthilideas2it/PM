using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBbmStockItem
{
    public double? IdStockItem { get; set; }

    public double? IdStockType { get; set; }

    public string? IdServiceType { get; set; }

    public DateTime? BoughtDate { get; set; }

    public string? Serialnumber { get; set; }

    public double? Price { get; set; }

    public string? Inventorynumber { get; set; }

    public string? Source { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? Barcode { get; set; }

    public string? ActualOperatingHouers { get; set; }

    public string? ActualUsageDays { get; set; }

    public DateTime? LastService { get; set; }

    public double? IdStockType2InventoryTypeIn { get; set; }

    public string? IdStockType2InventoryTypeOut { get; set; }

    public double? IdUserCreated { get; set; }

    public double? IdUserUpdated { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? DepreciationBaseValue { get; set; }

    public string? IdDepreciationMethod { get; set; }

    public string? EconomicLife { get; set; }

    public string? IdInvoiceAccountDepreciation { get; set; }

    public double? IdOwner { get; set; }

    public string? Condition { get; set; }

    public double? Sequence { get; set; }

    public string? IdStockSubhire { get; set; }

    public DateTime? LastRepair { get; set; }

    public DateTime? LastMaintenance { get; set; }

    public string? IdAddressSubhire { get; set; }

    public string? IdStockType2JobSubhire { get; set; }
}
