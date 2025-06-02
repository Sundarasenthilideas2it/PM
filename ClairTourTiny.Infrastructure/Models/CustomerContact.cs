using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerContact
{
    public string CustomerId { get; set; } = null!;

    public string CustomerNum { get; set; } = null!;

    public string SubNum { get; set; } = null!;

    public string? Name { get; set; }

    public string? Organization { get; set; }

    public string Status { get; set; } = null!;
}
