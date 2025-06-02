using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FrequencyVectorValue
{
    public int FrequencyVectorId { get; set; }

    public int AvgBinIndex { get; set; }

    public double FrequencyHz { get; set; }

    public int? LoFftbinIndex { get; set; }

    public int? HiFftbinIndex { get; set; }

    public virtual FrequencyVector FrequencyVector { get; set; } = null!;
}
