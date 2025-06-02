using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSysproAvailabilityTransaction
{
    public string Partno { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public double? Qty { get; set; }

    public string SourceType { get; set; } = null!;

    public string? SourceKey { get; set; }
}
