using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpHaywardBarcodeImportWithSerialNo
{
    public string? Id { get; set; }

    public string? Product { get; set; }

    public string? Store { get; set; }

    public string? StockType { get; set; }

    public string? AssetNumber { get; set; }

    public string? SerialNumber { get; set; }

    public string? Location { get; set; }

    public string? EffectiveDate { get; set; }

    public string? OpeningBalance { get; set; }

    public string? QuantityHeld { get; set; }

    public string? CurrentBalance { get; set; }

    public string? ImageLinkUrl { get; set; }
}
