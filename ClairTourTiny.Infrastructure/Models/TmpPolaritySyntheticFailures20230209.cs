using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPolaritySyntheticFailures20230209
{
    public int? FakeCurveId { get; set; }

    public int? ReferenceSetId { get; set; }

    public int? FailCurveId { get; set; }

    public int? PassCurveId { get; set; }

    public int? BinIndex { get; set; }

    public float? FactorReal { get; set; }

    public float? FactorImaginary { get; set; }

    public string? Description { get; set; }
}
