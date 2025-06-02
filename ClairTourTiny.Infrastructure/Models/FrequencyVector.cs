using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FrequencyVector
{
    public int FrequencyVectorId { get; set; }

    public double? SampleRateHz { get; set; }

    public double? MinFreqHz { get; set; }

    public double? MaxFreqHz { get; set; }

    public int? NumDecimatedBins { get; set; }

    public virtual ICollection<CabinetComponentTestMeasurement> CabinetComponentTestMeasurements { get; set; } = new List<CabinetComponentTestMeasurement>();

    public virtual ICollection<ComplexCurve> ComplexCurves { get; set; } = new List<ComplexCurve>();

    public virtual ICollection<FrequencyVectorValue> FrequencyVectorValues { get; set; } = new List<FrequencyVectorValue>();

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
