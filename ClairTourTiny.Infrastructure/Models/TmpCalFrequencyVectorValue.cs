using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpCalFrequencyVectorValue
{
    public string? AveragedBinIndex { get; set; }

    public string? FrequencyHz { get; set; }

    public string? LoFftbinIndex { get; set; }

    public string? HiFftbinIndex { get; set; }
}
