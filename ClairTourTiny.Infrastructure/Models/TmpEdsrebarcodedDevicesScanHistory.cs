using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsrebarcodedDevicesScanHistory
{
    public string Barcode { get; set; } = null!;

    public int Qty { get; set; }

    public string Status { get; set; } = null!;

    public string ScannedBy { get; set; } = null!;

    public string? ScannedDate { get; set; }

    public DateTime? ScannedDateTime { get; set; }
}
