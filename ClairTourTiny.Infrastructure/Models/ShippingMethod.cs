using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingMethod
{
    public string ShippingMethodType { get; set; } = null!;

    public string ShippingMethodDesc { get; set; } = null!;

    public virtual ICollection<ShippingPricePerPound> ShippingPricePerPounds { get; set; } = new List<ShippingPricePerPound>();
}
