using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TempInventoryPartInStock
{
    public string? Contract { get; set; }

    public string? PartNo { get; set; }

    public string? ConfigurationId { get; set; }

    public string? LocationNo { get; set; }

    public string? LotBatchNo { get; set; }

    public string? SerialNo { get; set; }

    public string? EngChgLevel { get; set; }

    public string? WaivDevRejNo { get; set; }

    public decimal? ActivitySeq { get; set; }

    public decimal? HandlingUnitId { get; set; }

    public decimal? AvgUnitTransitCost { get; set; }

    public decimal? CountVariance { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public string? FreezeFlag { get; set; }

    public string? FreezeFlagDb { get; set; }

    public DateTime? LastActivityDate { get; set; }

    public DateTime? LastCountDate { get; set; }

    public string? LocationType { get; set; }

    public string? LocationTypeDb { get; set; }

    public decimal? QtyInTransit { get; set; }

    public decimal? QtyOnhand { get; set; }

    public decimal? QtyReserved { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? Source { get; set; }

    public string? Warehouse { get; set; }

    public string? BayNo { get; set; }

    public string? RowNo { get; set; }

    public string? TierNo { get; set; }

    public string? BinNo { get; set; }

    public string? AvailabilityControlId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? RotablePartPoolId { get; set; }

    public string? ProjectId { get; set; }

    public decimal? CatchQtyInTransit { get; set; }

    public decimal? CatchQtyOnhand { get; set; }

    public string? PartOwnership { get; set; }

    public string? PartOwnershipDb { get; set; }

    public string? OwningCustomerNo { get; set; }

    public string? OwningVendorNo { get; set; }

    public decimal? LatestTransactionId { get; set; }

    public string? Objkey { get; set; }

    public string? Objversion { get; set; }

    public string? Objid { get; set; }
}
