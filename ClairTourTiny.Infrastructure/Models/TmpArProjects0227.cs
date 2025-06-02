using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArProjects0227
{
    public string? Entityno { get; set; }

    public string? Entitydesc { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string Custno { get; set; } = null!;

    public int Subno { get; set; }

    public string? Agency { get; set; }

    public string Subcontract { get; set; } = null!;

    public string? Industry { get; set; }

    public string? InternalOrg { get; set; }

    public string? Engactivecd { get; set; }

    public string Finactivecd { get; set; } = null!;

    public string Respempno { get; set; } = null!;

    public string Entitytype { get; set; } = null!;

    public string Probability { get; set; } = null!;

    public string Proptype { get; set; } = null!;

    public string? Plactivecd { get; set; }

    public string Sfactivecd { get; set; } = null!;

    public string? Opsmgr { get; set; }

    public string Bidmarkup { get; set; } = null!;

    public string BillingCompany { get; set; } = null!;

    public string? Bidroot { get; set; }

    public string Currency { get; set; } = null!;

    public DateTime? LoadOut { get; set; }

    public DateTime? CrewPrep { get; set; }

    public DateTime? FirstShow { get; set; }

    public DateTime? LastShow { get; set; }
}
