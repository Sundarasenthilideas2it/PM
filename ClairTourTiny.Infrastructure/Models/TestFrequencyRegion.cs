using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TestFrequencyRegion
{
    public string Test { get; set; } = null!;

    public decimal TimeSeconds { get; set; }

    public double FrequencyHz { get; set; }

    public virtual Test TestNavigation { get; set; } = null!;
}
