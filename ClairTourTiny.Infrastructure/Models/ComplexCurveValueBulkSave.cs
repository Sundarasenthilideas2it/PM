using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ComplexCurveValueBulkSave
{
    public int SessionId { get; set; }

    public int CurveFakeId { get; set; }

    public int BinIndex { get; set; }

    public double RealDataValue { get; set; }

    public double ImaginaryDataValue { get; set; }
}
