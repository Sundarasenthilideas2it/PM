using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Peempacct
{
    public string Empno { get; set; } = null!;

    public string Bankid { get; set; } = null!;

    public string Bankname { get; set; } = null!;

    public string Acctid { get; set; } = null!;

    public string ChkSavCd { get; set; } = null!;

    public int Seqno { get; set; }

    public decimal Maxamt { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
