using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UsedGearSalesCollection
{
    public string ShopifyCollectionId { get; set; } = null!;

    public string ShopifyCollectionDescription { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string? Commodity { get; set; }

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual ICollection<FinesseCategoriesShopifyCollection> FinesseCategoriesShopifyCollections { get; set; } = new List<FinesseCategoriesShopifyCollection>();

    public virtual ICollection<UsedGearSalesPartCollection> UsedGearSalesPartCollections { get; set; } = new List<UsedGearSalesPartCollection>();
}
