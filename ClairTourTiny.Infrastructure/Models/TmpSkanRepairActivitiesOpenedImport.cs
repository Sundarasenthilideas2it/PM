using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanRepairActivitiesOpenedImport
{
    public long? IdActivity { get; set; }

    public long? IdTicket { get; set; }

    public DateTime CreatedByDate { get; set; }

    public string UserName { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public string Id { get; set; } = null!;
}
