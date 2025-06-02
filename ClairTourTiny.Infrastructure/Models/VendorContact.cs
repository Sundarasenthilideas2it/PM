using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class VendorContact
{
    public string VendorId { get; set; } = null!;

    public string VendorNum { get; set; } = null!;

    public string SiteNum { get; set; } = null!;

    public string? Name { get; set; }

    public string? Organization { get; set; }

    public string Status { get; set; } = null!;
}
