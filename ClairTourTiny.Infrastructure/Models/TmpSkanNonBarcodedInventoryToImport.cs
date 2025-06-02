using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanNonBarcodedInventoryToImport
{
    public string Id { get; set; } = null!;

    public string StockTypeId { get; set; } = null!;

    public string? ResourceName { get; set; }

    public string ItemId { get; set; } = null!;

    public long Quantity { get; set; }

    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string? FlexPartDesc { get; set; }
}
