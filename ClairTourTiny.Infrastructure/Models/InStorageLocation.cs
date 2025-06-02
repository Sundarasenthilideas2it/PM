using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InStorageLocation
{
    public int IdStoragelocation { get; set; }

    public string Storagelocation { get; set; } = null!;

    public virtual ICollection<Inpart> Inparts { get; set; } = new List<Inpart>();

    public virtual ICollection<StorageLocationNotificationRecipient> StorageLocationNotificationRecipients { get; set; } = new List<StorageLocationNotificationRecipient>();
}
