using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpHaywardBarcodeImport
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

    public string? Parentpartno { get; set; }

    public string? ParentuniqueNo { get; set; }

    public string? ParentserialNo { get; set; }

    public int? HeldInWarehouse { get; set; }

    public string? Dup { get; set; }

    public DateTime? LastDupTransaction { get; set; }

    public bool? NeedToChangeDupBarcode { get; set; }

    public bool? NeedEmailForNewBarcode { get; set; }

    public string? Partno { get; set; }

    public string? UniqueNo { get; set; }

    public string? Batchno { get; set; }

    public string? Dept { get; set; }

    public string? Bld { get; set; }

    public string? Area { get; set; }

    public string? Row { get; set; }

    public string? SerialNo { get; set; }

    public int? Onhand { get; set; }

    public DateTime? Receipt { get; set; }
}
