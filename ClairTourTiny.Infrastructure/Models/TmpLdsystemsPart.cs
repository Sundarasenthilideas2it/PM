using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpLdsystemsPart
{
    public string Id { get; set; } = null!;

    public string? Categories { get; set; }

    public string? ResourceName { get; set; }

    public string? ResourceShortName { get; set; }

    public string? ItemSize { get; set; }

    public int FlexSerializedQty { get; set; }

    public float ReplacementCost { get; set; }

    public string? NarrativeDescription { get; set; }

    public string? DisplayString { get; set; }

    public string? RcNumber { get; set; }

    public DateTime CreatedByDate { get; set; }

    public DateTime LastEditDate { get; set; }

    public float PurchaseCost { get; set; }

    public string? PartNumber { get; set; }

    public string? Manufacturer { get; set; }

    public float Weight { get; set; }

    public string? Sku { get; set; }

    public string? ManufactureCountry { get; set; }

    public float Height { get; set; }

    public float Width { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ShortHand { get; set; }

    public string? IvtNotes { get; set; }

    public string? UnitOfLength { get; set; }

    public string? UnitOfWeight { get; set; }

    public short IsContainer { get; set; }

    public short Expendable { get; set; }

    public short IsDiscontinued { get; set; }

    public short VirtualItem { get; set; }

    public short ContentsPermanent { get; set; }

    public short ContentsAvailable { get; set; }

    public short SerializedContents { get; set; }

    public short IsPickContainer { get; set; }

    public short TrackedBySn { get; set; }

    public string PartNoIfNeeded { get; set; } = null!;
}
