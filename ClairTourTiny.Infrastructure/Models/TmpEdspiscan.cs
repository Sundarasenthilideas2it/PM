using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdspiscan
{
    public string? Barcode { get; set; }

    public string? Qty { get; set; }

    public string? Status { get; set; }

    public string? Scannedby { get; set; }

    public string? Date { get; set; }
}
