using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartCatalogTab
{
    public string? PartNo { get; set; }

    public string? Description { get; set; }

    public string? InfoText { get; set; }

    public long? StdNameId { get; set; }

    public string? UnitCode { get; set; }

    public string? LotTrackingCode { get; set; }

    public string? SerialRule { get; set; }

    public string? SerialTrackingCode { get; set; }

    public string? EngSerialTrackingCode { get; set; }

    public string? PartMainGroup { get; set; }

    public string? Configurable { get; set; }

    public decimal? CustWarrantyId { get; set; }

    public decimal? SupWarrantyId { get; set; }

    public string? ConditionCodeUsage { get; set; }

    public string? SubLotRule { get; set; }

    public string? LotQuantityRule { get; set; }

    public string? PositionPart { get; set; }

    public string? InputUnitMeasGroupId { get; set; }

    public string? CatchUnitEnabled { get; set; }

    public string? MultilevelTracking { get; set; }

    public string? ComponentLotRule { get; set; }

    public string? StopArrivalIssuedSerial { get; set; }

    public decimal? WeightNet { get; set; }

    public string? UomForWeightNet { get; set; }

    public decimal? VolumeNet { get; set; }

    public string? UomForVolumeNet { get; set; }

    public decimal? FreightFactor { get; set; }

    public string? AllowAsNotConsumed { get; set; }

    public string? ReceiptIssueSerialTrack { get; set; }

    public string? StopNewSerialInRma { get; set; }

    public string? TechnicalDrawingNo { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }

    public string? ProductTypeClassif { get; set; }

    public string? CestCode { get; set; }

    public string? FciCode { get; set; }
}
