using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ActiveBidProjectsWithOrderedPartsNotOnProjectCalendar
{
    public string Entityno { get; set; } = null!;

    public string? Agency { get; set; }

    public string? Respempno { get; set; }

    public string? Opsmgr { get; set; }

    public string? Entitydesc { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? CBig { get; set; }
}
