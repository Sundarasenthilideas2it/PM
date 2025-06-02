using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerPhone
{
    public string CustomerId { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Type { get; set; } = null!;
}
