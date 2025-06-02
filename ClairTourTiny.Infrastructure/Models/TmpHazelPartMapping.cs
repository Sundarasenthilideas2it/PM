using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpHazelPartMapping
{
    public string ItemId { get; set; } = null!;

    public string? Partno { get; set; }

    public string? CheckedBy { get; set; }

    public DateTimeOffset? CheckedDate { get; set; }

    public virtual TmpHazelPart Item { get; set; } = null!;
}
