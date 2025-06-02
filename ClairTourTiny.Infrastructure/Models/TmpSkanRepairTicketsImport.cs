using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanRepairTicketsImport
{
    public long? IdTicket { get; set; }

    public string? BarCodeId { get; set; }

    public string? Entityno { get; set; }

    public string Id { get; set; } = null!;
}
