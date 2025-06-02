using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairActivitiesAttachment
{
    public int IdTicket { get; set; }

    public int IdActivity { get; set; }

    public string AttachmentPath { get; set; } = null!;

    public virtual RepairActivity RepairActivity { get; set; } = null!;
}
