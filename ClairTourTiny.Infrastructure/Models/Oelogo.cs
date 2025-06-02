using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Oelogo
{
    public string Oelocationcd { get; set; } = null!;

    public string Aplocationcd { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public byte[] Oelogo1 { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
