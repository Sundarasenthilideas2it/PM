using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MeasurementPurpose
{
    public string Purpose { get; set; } = null!;

    public virtual ICollection<CabinetComponentTestMeasurement> CabinetComponentTestMeasurements { get; set; } = new List<CabinetComponentTestMeasurement>();
}
