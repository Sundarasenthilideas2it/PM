using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class VendorEmail
{
    public string VendorId { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string Type { get; set; } = null!;
}
