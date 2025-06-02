using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuickSearchQuery
{
    public int Sortorder { get; set; }

    public string QuickSearchName { get; set; } = null!;

    public string QueryPrefix { get; set; } = null!;

    public string? QuerySearchFields { get; set; }

    public string? QuerySuffix { get; set; }

    public bool? IsExtendedSearch { get; set; }
}
