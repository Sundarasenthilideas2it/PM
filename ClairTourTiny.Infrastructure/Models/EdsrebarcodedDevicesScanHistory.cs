using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EdsrebarcodedDevicesScanHistory
{
    public DateTimeOffset ScannedDateTime { get; set; }

    public string Barcode { get; set; } = null!;

    public int Qty { get; set; }

    public string Status { get; set; } = null!;

    public string ScannedBy { get; set; } = null!;
}
