using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecProjectBillingDatum
{
    public string Entityno { get; set; } = null!;

    public string? BillingCompany { get; set; }

    public bool IsLocked { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public DateTime? FirstBillingDay { get; set; }

    public DateTime? LastBillingDay { get; set; }
}
