using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FinesseInventoryReceiptMessage
{
    public int Ref { get; set; }

    public string TransactionType { get; set; } = null!;

    public DateTime MessageDate { get; set; }

    public DateTime DueDate { get; set; }

    public DateTimeOffset TransactionDate { get; set; }

    public string Site { get; set; } = null!;

    public string? InternalCustomer { get; set; }

    public string? InternalDestination { get; set; }

    public string? InternalDestinationDescription { get; set; }

    public int LineNo { get; set; }

    public string PartNo { get; set; } = null!;

    public int Qty { get; set; }

    public string? InventoryLocation { get; set; }

    public string OrderNo { get; set; } = null!;

    public int PoLine { get; set; }

    public int PoRelease { get; set; }

    public string? SerialNo { get; set; }

    public string? LotBatchNo { get; set; }

    public string? ConditionCode { get; set; }

    public double? OrigMaterialReqNo { get; set; }

    public double? OrigMaterialReqRel { get; set; }

    public string? LineNote { get; set; }

    public string? MatReqRef { get; set; }

    public string UserId { get; set; } = null!;

    public string? HeaderNote { get; set; }

    public string? Error { get; set; }

    public bool IsSent { get; set; }

    public DateTimeOffset? Updated { get; set; }

    public string? MessageBody { get; set; }

    public string? RawError { get; set; }

    public bool ReadyToSend { get; set; }
}
