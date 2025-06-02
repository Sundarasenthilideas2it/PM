using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Incommodity
{
    public string Commodity { get; set; } = null!;

    public string Commoditydesc { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public Guid FileStorageGuid { get; set; }

    public bool CanHaveSafeWorkingLoad { get; set; }

    public virtual ICollection<CommodityNotificationRecipient> CommodityNotificationRecipients { get; set; } = new List<CommodityNotificationRecipient>();

    public virtual ICollection<FinesseCategoriesShopifyCollection> FinesseCategoriesShopifyCollections { get; set; } = new List<FinesseCategoriesShopifyCollection>();

    public virtual ICollection<Inpart> Inparts { get; set; } = new List<Inpart>();

    public virtual ICollection<PartSecondaryCategory> PartSecondaryCategories { get; set; } = new List<PartSecondaryCategory>();

    public virtual ICollection<PartSecondaryCategoriesBackUp> PartSecondaryCategoriesBackUps { get; set; } = new List<PartSecondaryCategoriesBackUp>();

    public virtual ICollection<TmpAngelfishPartsMapping> TmpAngelfishPartsMappings { get; set; } = new List<TmpAngelfishPartsMapping>();

    public virtual ICollection<TmpLdsystemsPartsMapping> TmpLdsystemsPartsMappings { get; set; } = new List<TmpLdsystemsPartsMapping>();
}
