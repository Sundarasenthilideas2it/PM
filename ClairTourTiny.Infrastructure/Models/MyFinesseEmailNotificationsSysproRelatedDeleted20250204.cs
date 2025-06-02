using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseEmailNotificationsSysproRelatedDeleted20250204
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
}
