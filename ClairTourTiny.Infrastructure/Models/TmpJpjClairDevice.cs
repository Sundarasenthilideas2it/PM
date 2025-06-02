using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjClairDevice
{
    public double? Sort { get; set; }

    public string? ItemNo { get; set; }

    public string? DeviceNo { get; set; }

    public string? ItemName { get; set; }

    public double? Qty { get; set; }

    public double? Qty1 { get; set; }

    public string? Barcode { get; set; }

    public string? SerialNo { get; set; }

    public string? InventoryNo { get; set; }

    public string? Owner { get; set; }

    public string? Comments { get; set; }

    public string? Site { get; set; }

    public string? JobNo { get; set; }

    public string? WorkshopNo { get; set; }

    public decimal? PurchasePrice { get; set; }

    public string? PurchaseDate { get; set; }

    public string? ParentItemNo { get; set; }

    public string? ParentDeviceNo { get; set; }

    public string? ParentBarcode { get; set; }

    public string? NonDevice { get; set; }
}
