using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ComplexCurveValue
{
    public int CurveId { get; set; }

    public int BinIndex { get; set; }

    public double RealDataValue { get; set; }

    public double ImaginaryDataValue { get; set; }

    public virtual ComplexCurve Curve { get; set; } = null!;
}
