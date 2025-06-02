using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpAngelfishPart
{
    public string ItemId { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public double? PurchasePrice { get; set; }

    public int Inventory { get; set; }

    public virtual TmpAngelfishPartsMapping? TmpAngelfishPartsMapping { get; set; }
}
