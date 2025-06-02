using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RealCurveValue
{
    public int CurveId { get; set; }

    public int SampleIndex { get; set; }

    public double DataValue { get; set; }

    public virtual RealCurve Curve { get; set; } = null!;
}
