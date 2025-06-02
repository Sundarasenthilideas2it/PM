using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Intransref4
{
    public string Ref4 { get; set; } = null!;

    public string Ref5desc { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
