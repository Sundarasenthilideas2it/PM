using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingPackageType
{
    public string ShippingPackageType1 { get; set; } = null!;

    public string ShippingPackageDesc { get; set; } = null!;

    public virtual ICollection<ShippingPackage> ShippingPackages { get; set; } = new List<ShippingPackage>();
}
