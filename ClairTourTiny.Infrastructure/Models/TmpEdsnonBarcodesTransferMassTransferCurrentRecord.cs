using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsnonBarcodesTransferMassTransferCurrentRecord
{
    public int? Qty { get; set; }

    public string? Partno { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string FromBatchNo { get; set; } = null!;

    public string? ToBatchNo { get; set; }

    public string FromDept { get; set; } = null!;

    public string ToDept { get; set; } = null!;

    public string FromArea { get; set; } = null!;

    public string ToArea { get; set; } = null!;

    public string? FromBld { get; set; }

    public string? ToBld { get; set; }

    public string Row { get; set; } = null!;

    public int Pieces { get; set; }

    public string ParentuniqueNo { get; set; } = null!;
}
