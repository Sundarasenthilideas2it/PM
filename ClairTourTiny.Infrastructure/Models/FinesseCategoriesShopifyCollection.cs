using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FinesseCategoriesShopifyCollection
{
    public string Commodity { get; set; } = null!;

    public string ShopifyCollectionId { get; set; } = null!;

    public string? CompanyCode { get; set; }

    public virtual Incommodity CommodityNavigation { get; set; } = null!;

    public virtual Company? CompanyCodeNavigation { get; set; }

    public virtual UsedGearSalesCollection ShopifyCollection { get; set; } = null!;
}
