using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartsWithOpenRepairTicket
{
    public string? Partno { get; set; }

    public string? UniqueNo { get; set; }

    public int IdTicket { get; set; }

    public int IdActivity { get; set; }

    public int? IsOpen { get; set; }
}
