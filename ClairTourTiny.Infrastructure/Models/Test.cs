using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Test
{
    public string Test1 { get; set; } = null!;

    public string SignalType { get; set; } = null!;

    public double SampleRateHz { get; set; }

    public int? FrequencyVectorId { get; set; }

    public virtual ICollection<CabinetComponentTestMeasurement> CabinetComponentTestMeasurements { get; set; } = new List<CabinetComponentTestMeasurement>();

    public virtual ICollection<ComponentTest> ComponentTests { get; set; } = new List<ComponentTest>();

    public virtual FrequencyVector? FrequencyVector { get; set; }

    public virtual ICollection<ReferenceSet1> ReferenceSet1s { get; set; } = new List<ReferenceSet1>();

    public virtual ICollection<TestFrequencyRegion> TestFrequencyRegions { get; set; } = new List<TestFrequencyRegion>();
}
