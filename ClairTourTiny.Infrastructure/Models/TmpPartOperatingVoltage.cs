using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPartOperatingVoltage
{
    public string Partno { get; set; } = null!;

    public double? OperatingVa { get; set; }

    public string? OperatingVacMin { get; set; }

    public string? OperatingVacMax { get; set; }
}
