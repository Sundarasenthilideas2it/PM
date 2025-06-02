using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjjobrevenueHistory
{
    public string Entityno { get; set; } = null!;

    public int Seqno { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public double Amount { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }
}
