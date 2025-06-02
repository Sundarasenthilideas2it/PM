using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartCatalog
{
    public string PartNo { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? InfoText { get; set; }

    public decimal StdNameId { get; set; }

    public string UnitCode { get; set; } = null!;

    public string LotTrackingCode { get; set; } = null!;

    public string SerialRule { get; set; } = null!;

    public string SerialTrackingCode { get; set; } = null!;

    public string EngSerialTrackingCode { get; set; } = null!;

    public string? PartMainGroup { get; set; }

    public string Configurable { get; set; } = null!;

    public double? CustWarrantyId { get; set; }

    public double? SupWarrantyId { get; set; }

    public string ConditionCodeUsage { get; set; } = null!;

    public string SubLotRule { get; set; } = null!;

    public string LotQuantityRule { get; set; } = null!;

    public string PositionPart { get; set; } = null!;

    public string? InputUnitMeasGroupId { get; set; }

    public string CatchUnitEnabled { get; set; } = null!;

    public string MultilevelTracking { get; set; } = null!;

    public string ComponentLotRule { get; set; } = null!;

    public string StopArrivalIssuedSerial { get; set; } = null!;

    public double? WeightNet { get; set; }

    public string? UomForWeightNet { get; set; }

    public double? VolumeNet { get; set; }

    public string? UomForVolumeNet { get; set; }

    public double FreightFactor { get; set; }

    public string AllowAsNotConsumed { get; set; } = null!;

    public string ReceiptIssueSerialTrack { get; set; } = null!;

    public string? StopNewSerialInRma { get; set; }

    public string? TechnicalDrawingNo { get; set; }

    public string? ProductTypeClassif { get; set; }

    public string? ProductTypeClassifDb { get; set; }

    public string? CestCode { get; set; }

    public string? FciCode { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }

    public virtual ICollection<DisassemblePart> DisassembleParts { get; set; } = new List<DisassemblePart>();
}
