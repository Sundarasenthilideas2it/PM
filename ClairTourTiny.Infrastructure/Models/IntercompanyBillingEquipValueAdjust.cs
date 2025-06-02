using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IntercompanyBillingEquipValueAdjust
{
    public string CompanyCode { get; set; } = null!;

    public double EquipValueAdjust { get; set; }

    public virtual Company CompanyCodeNavigation { get; set; } = null!;
}
