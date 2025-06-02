using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IncommodityHistory
{
    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }

    public string Commodity { get; set; } = null!;

    public string Commoditydesc { get; set; } = null!;

    public string Acctcd { get; set; } = null!;
}
