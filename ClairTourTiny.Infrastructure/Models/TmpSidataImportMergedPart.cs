using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSidataImportMergedPart
{
    public string? PartNumber { get; set; }

    public string? PartDescription { get; set; }

    public string? Commodity { get; set; }

    public string? PartQtyImported { get; set; }

    public string? RentalValueUsd { get; set; }

    public string? TotalPartValueAdded { get; set; }

    public string? IsStockOfSiPartInFinesse0 { get; set; }
}
