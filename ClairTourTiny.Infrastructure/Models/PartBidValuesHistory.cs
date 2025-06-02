using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartBidValuesHistory
{
    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }

    public string Partno { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public double Bidvalue { get; set; }

    public string Valuetype { get; set; } = null!;
}
