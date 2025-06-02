using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartMaintenance
{
    public string Partno { get; set; } = null!;

    public int Interval { get; set; }

    public string Caption { get; set; } = null!;

    public string? Instructions { get; set; }
}
