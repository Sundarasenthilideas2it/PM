using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BinWeightValue
{
    public int BinWeightId { get; set; }

    public int BinIndex { get; set; }

    public double FactorFromBinVariation { get; set; }

    public double StandardDeviationPerBin { get; set; }

    public virtual ReferenceSetParameter BinWeight { get; set; } = null!;
}
