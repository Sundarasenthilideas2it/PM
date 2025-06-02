using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class LatestLogon
{
    public string UserName { get; set; } = null!;

    public long? LogonCount { get; set; }

    public DateTime? LastLogonUtc { get; set; }
}
