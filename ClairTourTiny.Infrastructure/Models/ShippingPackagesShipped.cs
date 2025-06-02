using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingPackagesShipped
{
    public int IdPackageShipped { get; set; }

    public int IdPackage { get; set; }

    public string? ServiceTypeVendorCode { get; set; }

    public double? Weight { get; set; }

    public string? WeightUom { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public string? TrackingNumber { get; set; }

    public string? MasterTrackingNumber { get; set; }

    public double? BilledWeight { get; set; }

    public double? NetCharge { get; set; }

    public double? TotalCustomerCharge { get; set; }

    public DateTime? ShipDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? NumberOfPackages { get; set; }

    public virtual ShippingPackage IdPackageNavigation { get; set; } = null!;
}
