using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Component
{
    public string Component1 { get; set; } = null!;

    public string? ComponentType { get; set; }

    public int? ElementCount { get; set; }

    public string? ComponentDescription { get; set; }

    public virtual ICollection<CabinetComponent> CabinetComponents { get; set; } = new List<CabinetComponent>();

    public virtual ICollection<ComponentFailureCurve> ComponentFailureCurves { get; set; } = new List<ComponentFailureCurve>();

    public virtual ICollection<ComponentTest> ComponentTests { get; set; } = new List<ComponentTest>();

    public virtual ICollection<ReferenceSet1> ReferenceSet1s { get; set; } = new List<ReferenceSet1>();
}
