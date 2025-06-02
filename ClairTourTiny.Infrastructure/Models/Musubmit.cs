using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Musubmit
{
    public int Subseqno { get; set; }

    public string Subdesc { get; set; } = null!;

    public string Cmndline { get; set; } = null!;

    public DateTime Datetime { get; set; }

    public int Priority { get; set; }

    public string Subdefault { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
