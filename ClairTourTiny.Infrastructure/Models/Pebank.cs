using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pebank
{
    public string Bankno { get; set; } = null!;

    public string Payperiod { get; set; } = null!;

    public string Descr { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public int Chklineup { get; set; }

    public int Maxcheck { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
