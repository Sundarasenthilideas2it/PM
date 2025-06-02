using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerSearch
{
    public string Custno { get; set; } = null!;

    public string? Name { get; set; }

    public string? SearchString { get; set; }
}
