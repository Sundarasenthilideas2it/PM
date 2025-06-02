using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GlentitiesIndexViewTableHighLatency
{
    public string Entityno { get; set; } = null!;

    public string? Proptype { get; set; }

    public string Engactivecd { get; set; } = null!;

    public string Entitytype { get; set; } = null!;

    public string Finactivecd { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public double? Bidmarkup { get; set; }

    public string Subcontract { get; set; } = null!;

    public string? Industry { get; set; }

    public string Agency { get; set; } = null!;

    public string? Opsmgr { get; set; }

    public string? Respempno { get; set; }

    public string? SecondaryOpsEmpno { get; set; }
}
