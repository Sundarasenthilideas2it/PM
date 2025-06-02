using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class State
{
    public string Statecode { get; set; } = null!;

    public string Statedesc { get; set; } = null!;

    public byte? Pollstarid { get; set; }

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1CollStateCdNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1DelStateCdNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1VendstatecdNavigations { get; set; } = new List<PurchaseOrder1>();
}
