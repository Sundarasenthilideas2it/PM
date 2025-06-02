using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class KnownClairTourTestSchemaDifference
{
    public string? Type { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public string? ObjectName { get; set; }

    public string? Difference { get; set; }

    public DateTime ReviewDate { get; set; }

    public string ReviewAction { get; set; } = null!;

    public string? Notes { get; set; }
}
