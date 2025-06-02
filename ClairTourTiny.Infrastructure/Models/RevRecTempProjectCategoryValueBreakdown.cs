using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecTempProjectCategoryValueBreakdown
{
    public string Entityno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string? ValueToUse { get; set; }

    public virtual RevRecCategory CategoryNavigation { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
