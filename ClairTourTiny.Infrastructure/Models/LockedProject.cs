using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class LockedProject
{
    public string Entityno { get; set; } = null!;

    public DateTimeOffset LockDate { get; set; }

    public bool IsSoftLock { get; set; }

    public string ServerName { get; set; } = null!;

    public string LoginName { get; set; } = null!;

    public string? HostName { get; set; }

    public short SessionId { get; set; }

    public DateTime SessionLoginTime { get; set; }
}
