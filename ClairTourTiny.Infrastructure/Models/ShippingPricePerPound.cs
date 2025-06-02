using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingPricePerPound
{
    public string FromWarehouse { get; set; } = null!;

    public string ToWarehouse { get; set; } = null!;

    public string ShippingMethodType { get; set; } = null!;

    public double PricePerPoundUsd { get; set; }

    public virtual Warehouse FromWarehouseNavigation { get; set; } = null!;

    public virtual ShippingMethod ShippingMethodTypeNavigation { get; set; } = null!;
}
