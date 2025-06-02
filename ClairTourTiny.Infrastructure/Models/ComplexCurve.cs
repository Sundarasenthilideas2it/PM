using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ComplexCurve
{
    public int CurveId { get; set; }

    public int FrequencyVectorId { get; set; }

    public string? Description { get; set; }

    public bool IsFactorsFromReferenceGood { get; set; }

    public virtual CabinetComponentTestMeasurement? CabinetComponentTestMeasurement { get; set; }

    public virtual ICollection<ComplexCurveValue> ComplexCurveValues { get; set; } = new List<ComplexCurveValue>();

    public virtual ICollection<ComponentFailureCurve> ComponentFailureCurves { get; set; } = new List<ComponentFailureCurve>();

    public virtual FrequencyVector FrequencyVector { get; set; } = null!;

    public virtual ICollection<ReferenceSetCurve> ReferenceSetCurves { get; set; } = new List<ReferenceSetCurve>();

    public virtual ICollection<ComplexCurve> ConstituentCurves { get; set; } = new List<ComplexCurve>();

    public virtual ICollection<ComplexCurve> Curves { get; set; } = new List<ComplexCurve>();
}
