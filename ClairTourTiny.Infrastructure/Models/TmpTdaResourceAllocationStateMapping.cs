using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaResourceAllocationStateMapping
{
    public int IdResourceAllocationState { get; set; }

    public string Type { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public int? SortOrder { get; set; }

    public int? Color { get; set; }

    public string CaptionDe { get; set; } = null!;

    public string CaptionEn { get; set; } = null!;

    public string? CaptionFr { get; set; }

    public string? CaptionCu { get; set; }

    public string? StatusCode { get; set; }
}
