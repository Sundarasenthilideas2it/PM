using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartTagIdeasHistory
{
    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }

    public string Partno { get; set; } = null!;

    public string Tag { get; set; } = null!;
}
