using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseEmailNotification
{
    public short IdQuery { get; set; }

    public string UserName { get; set; } = null!;

    public string Frequency { get; set; } = null!;

    public DateTime NextNotificationUtc { get; set; }

    public bool AttachCsv { get; set; }

    public bool EmbedTable { get; set; }

    public bool SuppressEmptyEmail { get; set; }

    public bool SingleEmailForSameQuery { get; set; }

    public DateTime? LastNotificationUtc { get; set; }

    public virtual Frequency FrequencyNavigation { get; set; } = null!;

    public virtual MyFinesseQuery IdQueryNavigation { get; set; } = null!;

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;
}
