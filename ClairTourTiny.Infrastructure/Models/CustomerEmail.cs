using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerEmail
{
    public string CustomerId { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string Type { get; set; } = null!;
}
