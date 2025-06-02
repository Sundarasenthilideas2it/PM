using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpLegacyLimitDiff
{
    public string? LegacyLimitId { get; set; }

    public string? ReferenceSetId { get; set; }

    public string? Cabinet { get; set; }

    public string? Component { get; set; }

    public string? Configuration { get; set; }

    public string? FreqIndex { get; set; }

    public string? FrequencyHz { get; set; }

    public string? LowerLimit { get; set; }

    public string? UpperLimit { get; set; }

    public string? LowerLimitDiff { get; set; }

    public string? UpperLimitDiff { get; set; }
}
