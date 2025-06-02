using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InUnitOfWeight
{
    public string ConversionShortname { get; set; } = null!;

    public string ConversionLongname { get; set; } = null!;

    public double ConversionFactorToPounds { get; set; }

    public double? ConversionFactorFromPounds { get; set; }

    public byte DisplayDecimalPlaces { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();

    public virtual ICollection<ShippingPackage> ShippingPackages { get; set; } = new List<ShippingPackage>();
}
