using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UnifiedAddress
{
    public int UnifiedContactId { get; set; }

    public string Source { get; set; } = null!;

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string City { get; set; } = null!;

    public string StateProvince { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string? Country { get; set; }

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual AddressDataSourceFieldMap AddressDataSourceFieldMap { get; set; } = null!;

    public virtual UnifiedContact UnifiedContact { get; set; } = null!;
}
