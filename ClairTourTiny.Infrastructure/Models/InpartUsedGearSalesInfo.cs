using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartUsedGearSalesInfo
{
    public string Partno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public double? ListPrice { get; set; }

    public double? ReservePrice { get; set; }

    public string? SalesPageSeo { get; set; }

    public string? NoteInternal { get; set; }

    public string? SalesDescription { get; set; }

    public bool? IsMarkedForSale { get; set; }

    public bool? SalesPageCreated { get; set; }

    public string? ShopifyId { get; set; }

    public long? QtyForSale { get; set; }

    public string? UsedGearSalesStatusTypeCode { get; set; }

    public string? Tags { get; set; }

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;

    public virtual UsedGearSalesStatusType? UsedGearSalesStatusTypeCodeNavigation { get; set; }
}
