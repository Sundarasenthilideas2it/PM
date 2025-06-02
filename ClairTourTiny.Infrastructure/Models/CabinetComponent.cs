using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetComponent
{
    public string Partno { get; set; } = null!;

    public int InputNumber { get; set; }

    public string Component { get; set; } = null!;

    public string DisplayDescription { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int? ExpectedPolaritySign { get; set; }

    public string SignalLevel { get; set; } = null!;

    public virtual Component ComponentNavigation { get; set; } = null!;

    public virtual Cabinet PartnoNavigation { get; set; } = null!;

    public virtual SignalLevel SignalLevelNavigation { get; set; } = null!;

    public virtual ICollection<Failure> Failures { get; set; } = new List<Failure>();
}
