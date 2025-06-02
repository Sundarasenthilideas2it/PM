using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StackTestDevice
{
    public int StackTestId { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int CabinetPosition { get; set; }

    public string Configuration { get; set; } = null!;

    public virtual ICollection<CabinetComponentTestMeasurement> CabinetComponentTestMeasurements { get; set; } = new List<CabinetComponentTestMeasurement>();

    public virtual CabinetConfiguration CabinetConfiguration { get; set; } = null!;

    public virtual StackTest StackTest { get; set; } = null!;
}
