using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Apbank
{
    public string Bankno { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public string Chkrpt { get; set; } = null!;

    public int Chklineup { get; set; }

    public int Invperchk { get; set; }

    public int Maxcheck { get; set; }

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string RouterNo { get; set; } = null!;

    public string BankAcctcd { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public bool IsPositivePay { get; set; }
}
