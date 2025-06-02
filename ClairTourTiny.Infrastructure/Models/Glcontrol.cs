using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Glcontrol
{
    public string Company { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public int Batchno { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
