using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpsDeviceCheckinNotification
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string? Warehouse { get; set; }

    public string? Project { get; set; }

    public string Recipients { get; set; } = null!;

    public string? CopyRecipients { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }
}
