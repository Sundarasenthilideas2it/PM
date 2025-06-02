using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ComponentFailureCurve
{
    public int CurveId { get; set; }

    public string Component { get; set; } = null!;

    public string FailureDescription { get; set; } = null!;

    public virtual Component ComponentNavigation { get; set; } = null!;

    public virtual ComplexCurve Curve { get; set; } = null!;
}
