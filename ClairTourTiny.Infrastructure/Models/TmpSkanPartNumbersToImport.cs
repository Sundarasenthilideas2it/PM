using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanPartNumbersToImport
{
    public string? FinessePartno { get; set; }

    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string Commmodity { get; set; } = null!;

    public string? GroupName { get; set; }

    public string? FullDisplayString { get; set; }

    public string LeadSource { get; set; } = null!;

    public string Package { get; set; } = null!;

    public int? Locationcd { get; set; }

    public double? LengthUom { get; set; }

    public double? DepthUom { get; set; }

    public double? WidthUom { get; set; }

    public string Commodity2 { get; set; } = null!;

    public string MaterialDesc { get; set; } = null!;

    public string? MaterialSpec { get; set; }

    public double? Projpercent { get; set; }

    public string? Source { get; set; }

    public double? Totmatcost1 { get; set; }

    public string? UserCreated { get; set; }

    public DateTime CreatedTime { get; set; }

    public int? IdManufacturer { get; set; }

    public string? ModelNo { get; set; }

    public string? Sku { get; set; }

    public double? RentalValueUsd { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedByDate { get; set; }

    public string CreatedByUser { get; set; } = null!;

    public string? ResourceName { get; set; }

    public string? BarCodeId { get; set; }

    public string? ResourceShortName { get; set; }

    public string? NarrativeDescription { get; set; }

    public string? DisplayString { get; set; }

    public string? BarCodeLabel { get; set; }

    public string? ItemId { get; set; }

    public string? ShortHand { get; set; }

    public string? Manufacturer { get; set; }

    public string? ManufactureCountry { get; set; }

    public float? Weight { get; set; }

    public float? Height { get; set; }

    public float? Length { get; set; }

    public float? Width { get; set; }

    public short? IsContainer { get; set; }

    public string? IvtNotes { get; set; }

    public float? ReplacementCost { get; set; }

    public float? PurchaseCost { get; set; }

    public short? IsPickContainer { get; set; }

    public short? SerializedContents { get; set; }

    public short? ContentsAvailable { get; set; }

    public short? ContentsPermanent { get; set; }
}
