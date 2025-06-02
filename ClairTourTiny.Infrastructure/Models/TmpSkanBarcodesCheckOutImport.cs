using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanBarcodesCheckOutImport
{
    public long Quantity { get; set; }

    public string? Partno { get; set; }

    public string? BarCodeId { get; set; }

    public string? SerialNumber { get; set; }

    public string Id { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? SerialNumberId { get; set; }

    public string? LineItemId { get; set; }
}
