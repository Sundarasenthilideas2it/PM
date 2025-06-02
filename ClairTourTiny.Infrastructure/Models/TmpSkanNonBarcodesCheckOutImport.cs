using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanNonBarcodesCheckOutImport
{
    public long? Qty { get; set; }

    public string? BarCodeId { get; set; }

    public DateTime? ScanTimestamp { get; set; }

    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string? ResourceName { get; set; }

    public string? Entityno { get; set; }

    public string Entitydesc { get; set; } = null!;
}
