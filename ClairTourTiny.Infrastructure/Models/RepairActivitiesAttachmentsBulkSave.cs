using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairActivitiesAttachmentsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public int IdTicket { get; set; }

    public int IdActivity { get; set; }

    public string AttachmentPath { get; set; } = null!;
}
