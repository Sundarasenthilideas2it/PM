using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpCorrectionCurveDataValue
{
    public int? CurveId { get; set; }

    public int? SampleIndex { get; set; }

    public float? DataValue { get; set; }
}
