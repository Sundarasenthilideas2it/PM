using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GlentitiesIndexViewTable
{
    public string Entityno { get; set; } = null!;

    public string Proptype { get; set; } = null!;

    public string? Engactivecd { get; set; }

    public string? Entitytype { get; set; }

    public string? Finactivecd { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public double? Bidmarkup { get; set; }

    public string? Subcontract { get; set; }

    public string? Industry { get; set; }

    public string? Agency { get; set; }

    public string? Entitydesc { get; set; }

    public string? Opsmgr { get; set; }

    public string? Respempno { get; set; }

    public string? SecondaryOpsEmpno { get; set; }

    public string? BillingCompany { get; set; }

    public virtual Pjproptype ProptypeNavigation { get; set; } = null!;
}
