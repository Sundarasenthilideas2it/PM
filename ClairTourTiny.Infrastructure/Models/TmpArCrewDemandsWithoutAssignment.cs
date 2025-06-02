using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArCrewDemandsWithoutAssignment
{
    public string Jobno { get; set; } = null!;

    public string? Entityno { get; set; }

    public string? Jobtyp { get; set; }

    public string? Jobdesc { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public decimal? JDemand { get; set; }

    public double? EstHours { get; set; }
}
