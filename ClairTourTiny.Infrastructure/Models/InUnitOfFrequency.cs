using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InUnitOfFrequency
{
    public int UnitId { get; set; }

    public string UnitName { get; set; } = null!;

    public string UnitSymbol { get; set; } = null!;

    public double ConversionValue { get; set; }
}
