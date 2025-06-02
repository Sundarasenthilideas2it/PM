using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WarehouseLateReturnsLastNotification
{
    public string WarehouseCode { get; set; } = null!;

    public DateOnly NotifiedThroughDate { get; set; }

    public DateTime NotificationTimeUtc { get; set; }

    public virtual Warehouse WarehouseCodeNavigation { get; set; } = null!;
}
