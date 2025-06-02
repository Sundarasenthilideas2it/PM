using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingPackage
{
    public int IdPackage { get; set; }

    public int IdShippingRequest { get; set; }

    public string? ServiceTypeVendorCode { get; set; }

    public string? PackageType { get; set; }

    public double Weight { get; set; }

    public string WeightUom { get; set; } = null!;

    public double Length { get; set; }

    public double Width { get; set; }

    public double Height { get; set; }

    public string DimensionsUom { get; set; } = null!;

    public string? TrackingNumber { get; set; }

    public string? MasterTrackingNumber { get; set; }

    public double? BilledWeight { get; set; }

    public double? NetCharge { get; set; }

    public double? TotalCustomerCharge { get; set; }

    public int? NumberOfPackages { get; set; }

    public virtual InUnitOfLength DimensionsUomNavigation { get; set; } = null!;

    public virtual ShippingPackageType? PackageTypeNavigation { get; set; }

    public virtual ICollection<ShippingPackagesShipped> ShippingPackagesShippeds { get; set; } = new List<ShippingPackagesShipped>();

    public virtual InUnitOfWeight WeightUomNavigation { get; set; } = null!;
}
