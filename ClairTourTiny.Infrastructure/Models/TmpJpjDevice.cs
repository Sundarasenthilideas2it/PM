using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjDevice
{
    public string? Partno { get; set; }

    public string? ItemName { get; set; }

    public double? Qty { get; set; }

    public string? Barcode { get; set; }

    public string? SerialNo { get; set; }

    public string? InventoryNo { get; set; }

    public string? Owner { get; set; }

    public string? Warehouse { get; set; }

    public string? Projectno { get; set; }

    public double? WorkshopNo { get; set; }

    public string? ReceiptDate { get; set; }

    public string? ParentPartno { get; set; }

    public string? ParentBarcode { get; set; }
}
