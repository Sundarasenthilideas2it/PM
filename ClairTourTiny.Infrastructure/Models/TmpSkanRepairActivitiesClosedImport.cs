using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanRepairActivitiesClosedImport
{
    public long? IdActivity { get; set; }

    public long? IdTicket { get; set; }

    public DateTime? ResolvedDate { get; set; }

    public string UserName { get; set; } = null!;

    public string Id { get; set; } = null!;
}
