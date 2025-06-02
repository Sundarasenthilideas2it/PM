using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjLinkedInventoryToMoveToStagingArea
{
    public string Warehouse { get; set; } = null!;

    public string Parentpartno { get; set; } = null!;

    public int? ParentQty { get; set; }

    public string Parentpartdesc { get; set; } = null!;

    public string Childpartno { get; set; } = null!;

    public double LinkedQtyPerParent { get; set; }

    public string Childpartdesc { get; set; } = null!;

    public int? InstockQty { get; set; }

    public double? LinkedChildQty { get; set; }

    public double? QtyToMove { get; set; }

    public string Entityno { get; set; } = null!;
}
