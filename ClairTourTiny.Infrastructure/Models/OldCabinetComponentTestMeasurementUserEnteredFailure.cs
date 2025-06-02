using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OldCabinetComponentTestMeasurementUserEnteredFailure
{
    public int StackTestId { get; set; }

    public int CurveId { get; set; }

    public string FailureDescription { get; set; } = null!;

    public virtual ComplexCurve Curve { get; set; } = null!;

    public virtual StackTest StackTest { get; set; } = null!;
}
