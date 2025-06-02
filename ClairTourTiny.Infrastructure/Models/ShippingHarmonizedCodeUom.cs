using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingHarmonizedCodeUom
{
    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Inpart> Inparts { get; set; } = new List<Inpart>();
}
