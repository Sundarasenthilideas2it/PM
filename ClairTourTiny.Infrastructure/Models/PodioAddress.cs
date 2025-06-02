using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PodioAddress
{
    public string PodioId { get; set; } = null!;

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

    public virtual PodioContact Podio { get; set; } = null!;
}
