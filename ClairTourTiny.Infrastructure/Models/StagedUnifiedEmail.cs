using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StagedUnifiedEmail
{
    public int UnifiedContactId { get; set; }

    public string SourceId { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string Type { get; set; } = null!;
}
