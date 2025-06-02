using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muusersub
{
    public string Username { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public int Subseqno { get; set; }

    public DateTime Datetime { get; set; }

    public int Priority { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
