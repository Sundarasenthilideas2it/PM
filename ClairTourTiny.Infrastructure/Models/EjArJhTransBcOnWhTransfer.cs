using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjArJhTransBcOnWhTransfer
{
    public string? Serialnumber { get; set; }

    public string? Barcode { get; set; }

    public string? IOwner { get; set; }

    public string? FPartno { get; set; }

    public string SrcCaption { get; set; } = null!;

    public string? SrcNote { get; set; }

    public int? SrcFactor { get; set; }

    public string? SrcUser { get; set; }

    public string? SrcWh { get; set; }

    public int? SrcIdStockType2InventoryTypeParent { get; set; }

    public DateTime? SrcDate { get; set; }

    public string DestCaption { get; set; } = null!;

    public string? DestNote { get; set; }

    public int? DestFactor { get; set; }

    public string? DestUser { get; set; }

    public string? DestWh { get; set; }

    public int? DestIdStockType2InventoryTypeParent { get; set; }

    public DateTime? DestDate { get; set; }
}
