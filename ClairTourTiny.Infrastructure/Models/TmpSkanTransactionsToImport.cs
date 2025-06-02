using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanTransactionsToImport
{
    public string ScanMode { get; set; } = null!;

    public string Trantype { get; set; } = null!;

    public string? Partno { get; set; }

    public int Onhand { get; set; }

    public long? Qty { get; set; }

    public DateOnly? Trandate { get; set; }

    public string Orderno { get; set; } = null!;

    public string? Ref3 { get; set; }

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string? UniqueNo { get; set; }

    public string? Batchno { get; set; }

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Row { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateTime? Enterdate { get; set; }

    public string Userid { get; set; } = null!;

    public int HeldInWarehouse { get; set; }

    public int HiwmoveQty { get; set; }

    public string ParentuniqueNo { get; set; } = null!;

    public DateTime? EnterDateUtc { get; set; }

    public string PartNoImportId { get; set; } = null!;

    public string? SerialId { get; set; }

    public string? LineItemId { get; set; }
}
