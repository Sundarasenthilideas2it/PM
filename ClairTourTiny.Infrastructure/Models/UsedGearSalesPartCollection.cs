using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UsedGearSalesPartCollection
{
    public string Partno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string ShopifyCollectionId { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;

    public virtual UsedGearSalesCollection ShopifyCollection { get; set; } = null!;
}
