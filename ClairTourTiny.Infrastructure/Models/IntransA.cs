using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IntransA
{
    public string? Trantype { get; set; }

    public string? Partno { get; set; }

    public double? Onhand { get; set; }

    public double? Qty { get; set; }

    public DateOnly? Trandate { get; set; }

    public string? Orderno { get; set; }

    public string? Ref3 { get; set; }

    public string? Ref4 { get; set; }

    public string? Ref5 { get; set; }

    public string? UniqueNo { get; set; }

    public string? Batchno { get; set; }

    public string? Dept { get; set; }

    public string? Bld { get; set; }

    public string? Area { get; set; }

    public string? Row { get; set; }

    public string? SerialNo { get; set; }

    public DateTime? Enterdate { get; set; }

    public string? Userid { get; set; }

    public int? HeldInWarehouse { get; set; }

    public int? HiwmoveQty { get; set; }

    public string? ParentuniqueNo { get; set; }

    public DateTime? EnterDateUtc { get; set; }

    public Guid? Pk { get; set; }

    public DateTime AdateTime { get; set; }

    public string AuserId { get; set; } = null!;

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
