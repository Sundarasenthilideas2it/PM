using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReceiptInvLocation
{
    public decimal? ReceiptSequence { get; set; }

    public string? Contract { get; set; }

    public string PartNo { get; set; } = null!;

    public string? ConfigurationId { get; set; }

    public string? LocationNo { get; set; }

    public string? LotBatchNo { get; set; }

    public string? SerialNo { get; set; }

    public string? EngChgLevel { get; set; }

    public string? WaivDevRejNo { get; set; }

    public decimal? ActivitySeq { get; set; }

    public decimal? HandlingUnitId { get; set; }

    public string? LocationType { get; set; }

    public string? LocationTypeDb { get; set; }

    public decimal? InvQtyInStore { get; set; }

    public decimal? CatchQtyInStore { get; set; }

    public decimal? SourceQtyInStore { get; set; }

    public string? SourceRef1 { get; set; }

    public string? SourceRef2 { get; set; }

    public string? SourceRef3 { get; set; }

    public string? SourceRef4 { get; set; }

    public string? SourceRefType { get; set; }

    public string? SourceRefTypeDb { get; set; }

    public decimal? ReceiptNo { get; set; }

    public string? ProjectId { get; set; }

    public string? ManufacturerId { get; set; }

    public string? ManufacturerPartNo { get; set; }

    public DateTime? ManufacturedDate { get; set; }

    public string? ManufacturerSerialNo { get; set; }

    public string? ManufacturerLotBatchNo { get; set; }

    public string? Objkey { get; set; }

    public string? Objversion { get; set; }

    public string? Objid { get; set; }
}
