using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecTempProjectSummaryToCategorySummary
{
    public string Entityno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string Category { get; set; } = null!;

    public bool UseRfibreakout { get; set; }

    public double Amt { get; set; }

    public virtual RevRecCategory CategoryNavigation { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
