using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjBarcodeConflictsTestData20161223
{
    public string? EjpartNo { get; set; }

    public double? Qty { get; set; }

    public string? EjpartDesc { get; set; }

    public string Fpartno { get; set; } = null!;

    public string FpartDesc { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? EjserialNo { get; set; }

    public string FserialNo { get; set; } = null!;

    public string? InventoryNo { get; set; }

    public string? Ejowner { get; set; }

    public string? Ejwarehouse { get; set; }

    public string? Ejproject { get; set; }

    public double? Ejworkshop { get; set; }

    public string? Ejreceipt { get; set; }

    public string? EjparentPartNo { get; set; }

    public string? EjparentBarcode { get; set; }

    public string Fproject { get; set; } = null!;

    public string Fowner { get; set; } = null!;

    public string Fbld { get; set; } = null!;

    public string Flease { get; set; } = null!;

    public string Frev { get; set; } = null!;

    public DateTime Freceipt { get; set; }

    public string FparentPartNo { get; set; } = null!;

    public string FparentBarcode { get; set; } = null!;
}
