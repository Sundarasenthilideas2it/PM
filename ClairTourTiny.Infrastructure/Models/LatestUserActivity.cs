using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class LatestUserActivity
{
    public string ServerName { get; set; } = null!;

    public string LoginName { get; set; } = null!;

    public string HostName { get; set; } = null!;

    public string AppName { get; set; } = null!;

    public DateTime? UserActivityTimeUtc { get; set; }

    public DateTime DbConnectionTimeUtc { get; set; }

    public long DbConnectionCount { get; set; }
}
