using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseQueryRunsAverage
{
    public string Username { get; set; } = null!;

    public short IdQuery { get; set; }

    public string? Querycaption { get; set; }

    public string Category { get; set; } = null!;

    public int? ExecutedQty { get; set; }

    public int? AvgMilliseconds { get; set; }

    public int? SecondsWasted { get; set; }
}
