using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StorageLocationNotificationRecipient
{
    public string Warehouse { get; set; } = null!;

    public int IdStoragelocation { get; set; }

    public string Recipients { get; set; } = null!;

    public virtual InStorageLocation IdStoragelocationNavigation { get; set; } = null!;

    public virtual Glentity WarehouseNavigation { get; set; } = null!;
}
