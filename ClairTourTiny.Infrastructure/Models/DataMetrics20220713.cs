using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DataMetrics20220713
{
    public string? StackTestId { get; set; }

    public string? CurveId { get; set; }

    public string? Station { get; set; }

    public string? Barcode { get; set; }

    public string? Cabinet { get; set; }

    public string? CabinetNumber { get; set; }

    public string? Configuration { get; set; }

    public string? Component { get; set; }

    public string? InputNumber { get; set; }

    public float? PeakValue { get; set; }

    public float? FractionOfIdeal { get; set; }

    public string? FilePath { get; set; }
}
