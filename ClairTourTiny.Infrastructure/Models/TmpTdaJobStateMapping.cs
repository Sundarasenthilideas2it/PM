using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaJobStateMapping
{
    public int IdJobState { get; set; }

    public string JobState { get; set; } = null!;

    public int? SortOrder { get; set; }

    public string JobStateEn { get; set; } = null!;

    public int? IdJobType { get; set; }

    public string JobType { get; set; } = null!;

    public string JobTypeEn { get; set; } = null!;

    public string? Engactivecd { get; set; }

    public string? Proptype { get; set; }
}
