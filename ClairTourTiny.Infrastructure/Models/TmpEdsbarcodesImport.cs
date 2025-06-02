using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsbarcodesImport
{
    public long? Invseriid { get; set; }

    public long? Inviid { get; set; }

    public string? Sku { get; set; }

    public long? Siteiid { get; set; }

    public string? WarehouseCode { get; set; }

    public string? Barcode { get; set; }

    public string? Barcode2 { get; set; }

    public string? Mfgserialnum { get; set; }

    public DateTime? Dateacquired { get; set; }

    public DateTime? Dateretired { get; set; }

    public double? Soldprice { get; set; }

    public int? Itemstatus { get; set; }

    public string? Canrent { get; set; }

    public string? Cansell { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Timeindept { get; set; }

    public string? Currentlocation { get; set; }

    public string? Contractresv { get; set; }

    public string? Consigned { get; set; }
}
