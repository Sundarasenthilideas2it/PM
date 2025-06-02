using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSpeakerComponentImpedanceDatum
{
    public int? StackTestId { get; set; }

    public int? TestIteration { get; set; }

    public DateTime? StackTestDateTimeOffset { get; set; }

    public string? Barcode { get; set; }

    public string? CabinetNumber { get; set; }

    public string? CabinetConfiguration { get; set; }

    public string? ComponentType { get; set; }

    public string? ComponentNumber { get; set; }

    public int? BinIndex { get; set; }

    public double? Real { get; set; }

    public double? Imaginary { get; set; }

    public int? CurveId { get; set; }
}
