using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanPartNumbersView
{
    public string Id { get; set; } = null!;

    public DateTime CreatedByDate { get; set; }

    public string CreatedByUser { get; set; } = null!;

    public string? Description { get; set; }

    public string? BarCodeId { get; set; }

    public string? ResourceShortName { get; set; }

    public string? NarrativeDescription { get; set; }

    public string? DisplayString { get; set; }

    public string? BarCodeLabel { get; set; }

    public string? ShortHand { get; set; }

    public string? Manufacturer { get; set; }

    public string? ManufactureCountry { get; set; }

    public float? Weight { get; set; }

    public float? Height { get; set; }

    public float? Length { get; set; }

    public float? Width { get; set; }

    public short? IsContainer { get; set; }

    public string? Sku { get; set; }

    public string? IvtNotes { get; set; }

    public float? ReplacementCost { get; set; }

    public float? PurchasePrice { get; set; }

    public short? IsPickContainer { get; set; }

    public short? SerializedContents { get; set; }

    public short? ContentsAvailable { get; set; }

    public short? ContentsPermanent { get; set; }
}
