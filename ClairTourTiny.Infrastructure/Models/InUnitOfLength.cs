using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InUnitOfLength
{
    public string ConversionShortname { get; set; } = null!;

    public string ConversionLongname { get; set; } = null!;

    public double ConversionFactorToInches { get; set; }

    public double? ConversionFactorFromInches { get; set; }

    public byte DisplayDecimalPlaces { get; set; }

    public byte VolumeDisplayDecimalPlaces { get; set; }

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();

    public virtual ICollection<ShippingPackage> ShippingPackages { get; set; } = new List<ShippingPackage>();
}
