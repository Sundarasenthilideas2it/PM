using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StagedUnifiedPhone
{
    public int UnifiedContactId { get; set; }

    public string SourceId { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Type { get; set; } = null!;
}
