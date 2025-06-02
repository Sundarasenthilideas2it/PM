using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Ippool
{
    public string IppoolName { get; set; } = null!;

    public string Iplow { get; set; } = null!;

    public string Iphigh { get; set; } = null!;
}
