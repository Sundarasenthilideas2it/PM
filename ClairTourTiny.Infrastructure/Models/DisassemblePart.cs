using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DisassemblePart
{
    public string ParentPartNo { get; set; } = null!;

    public string ChildPartNo { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal? PricePercentage { get; set; }

    public virtual Inpart ChildPartNoNavigation { get; set; } = null!;

    public virtual PartCatalog ParentPartNoNavigation { get; set; } = null!;
}
