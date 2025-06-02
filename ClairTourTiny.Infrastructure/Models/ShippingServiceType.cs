using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingServiceType
{
    public string VendorFriendlyName { get; set; } = null!;

    public string? Vendno { get; set; }

    public string? SiteNo { get; set; }

    public string? ServiceTypeVendorCode { get; set; }

    public string ServiceType { get; set; } = null!;

    public bool? IsInternational { get; set; }

    public bool? IsDomestic { get; set; }

    public int? DeliveryDays { get; set; }

    public string? DeliveryTimeGuarantee { get; set; }

    public int? SortOrder { get; set; }

    public string DisplayName { get; set; } = null!;

    public double MarkUpFactor { get; set; }
}
