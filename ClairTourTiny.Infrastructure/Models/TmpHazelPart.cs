using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpHazelPart
{
    public double? LineNo { get; set; }

    public string ItemId { get; set; } = null!;

    public string? Categories { get; set; }

    public string? Description { get; set; }

    public string? ItemSize { get; set; }

    public string? Qty { get; set; }

    public double? UnitGbp { get; set; }

    public double? TotalGbp { get; set; }

    public Guid? FlexId { get; set; }

    public virtual TmpHazelPartMapping? TmpHazelPartMapping { get; set; }
}
