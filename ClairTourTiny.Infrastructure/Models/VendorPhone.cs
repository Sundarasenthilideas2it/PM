using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class VendorPhone
{
    public string VendorId { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Type { get; set; } = null!;
}
