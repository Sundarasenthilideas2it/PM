using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ConnectionFailureLog
{
    public DateTime LoginTime { get; set; }

    public string HostName { get; set; } = null!;

    public string ProgramName { get; set; } = null!;

    public string LoginName { get; set; } = null!;

    public DateTime HostFailureTime { get; set; }

    public DateTime HostRecoverTime { get; set; }

    public DateTime TransactionTime { get; set; }

    public string? Note { get; set; }

    public int SqlconnectionAttempts { get; set; }
}
