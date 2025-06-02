using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CommodityNotificationRecipient
{
    public string Warehouse { get; set; } = null!;

    public string Commodity { get; set; } = null!;

    public string Recipients { get; set; } = null!;

    public virtual Incommodity CommodityNavigation { get; set; } = null!;

    public virtual Warehouse WarehouseNavigation { get; set; } = null!;
}
