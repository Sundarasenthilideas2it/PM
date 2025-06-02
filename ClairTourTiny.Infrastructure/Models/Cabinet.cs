using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Cabinet
{
    public string Partno { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string DisplayColor { get; set; } = null!;

    public string SignalLevel { get; set; } = null!;

    public bool Visualize { get; set; }

    public virtual ICollection<CabinetComponent> CabinetComponents { get; set; } = new List<CabinetComponent>();

    public virtual ICollection<CabinetConfiguration> CabinetConfigurations { get; set; } = new List<CabinetConfiguration>();

    public virtual Inpart PartnoNavigation { get; set; } = null!;

    public virtual SignalLevel SignalLevelNavigation { get; set; } = null!;

    public virtual ICollection<Failure> Failures { get; set; } = new List<Failure>();
}
