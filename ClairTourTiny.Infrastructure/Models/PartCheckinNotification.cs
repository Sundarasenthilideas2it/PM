using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartCheckinNotification
{
    public string UniqueNo { get; set; } = null!;

    public string? Warehouse { get; set; }

    public string? Project { get; set; }

    public string Recipients { get; set; } = null!;

    public string? CopyRecipients { get; set; }

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? UserCreated { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool DeleteAfterSending { get; set; }

    public virtual Glentity? ProjectNavigation { get; set; }

    public virtual Warehouse? WarehouseNavigation { get; set; }
}
