using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairTicketsRebarcoded20220509
{
    public int IdTicket { get; set; }

    public string? OriginalBarcode { get; set; }

    public string NewBarcode { get; set; } = null!;
}
