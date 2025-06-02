using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class VenuesAndShippingDestination
{
    public string SourceData { get; set; } = null!;

    public string? LocationName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? ValueMember { get; set; }

    public string? DisplayMember { get; set; }
}
