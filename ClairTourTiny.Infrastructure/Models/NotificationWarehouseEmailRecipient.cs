using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class NotificationWarehouseEmailRecipient
{
    public string WarehouseCode { get; set; } = null!;

    public string PropType { get; set; } = null!;

    public string Recipients { get; set; } = null!;

    public virtual Pjproptype PropTypeNavigation { get; set; } = null!;

    public virtual Warehouse WarehouseCodeNavigation { get; set; } = null!;
}
