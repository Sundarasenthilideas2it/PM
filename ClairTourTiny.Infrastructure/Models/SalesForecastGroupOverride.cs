using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SalesForecastGroupOverride
{
    public string BillingCompany { get; set; } = null!;

    public string Warehouse { get; set; } = null!;

    public string SalesForecastGroup { get; set; } = null!;

    public virtual Company BillingCompanyNavigation { get; set; } = null!;

    public virtual Warehouse WarehouseNavigation { get; set; } = null!;
}
