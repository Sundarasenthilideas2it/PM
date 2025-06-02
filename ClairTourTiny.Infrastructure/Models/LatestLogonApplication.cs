using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class LatestLogonApplication
{
    public string UserName { get; set; } = null!;

    public string ProgramName { get; set; } = null!;

    public long? LogonCount { get; set; }

    public DateTime? LastLogonUtc { get; set; }
}
