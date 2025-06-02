using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingDestinationType
{
    public string DestinationTypeCode { get; set; } = null!;

    public string DestinationTypeDesc { get; set; } = null!;

    public virtual ICollection<ShippingRequestForShipmentVault> ShippingRequestForShipmentVaults { get; set; } = new List<ShippingRequestForShipmentVault>();
}
