using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StagedUnifiedAddress
{
    public int UnifiedContactId { get; set; }

    public string? SourceId { get; set; }

    public string Source { get; set; } = null!;

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? City { get; set; }

    public string? StateProvince { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string Type { get; set; } = null!;
}
