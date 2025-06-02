using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaNonBarcodedDguvItemsToCheckOutToJob
{
    public short SessionId { get; set; }

    public int? TfrQty { get; set; }

    public string? FinessePartNo { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string FromBatchNo { get; set; } = null!;

    public string ToBatchNo { get; set; } = null!;

    public string FromDept { get; set; } = null!;

    public string ToDept { get; set; } = null!;

    public string FromArea { get; set; } = null!;

    public string ToArea { get; set; } = null!;

    public string FromBld { get; set; } = null!;

    public string ToBld { get; set; } = null!;

    public string Row { get; set; } = null!;

    public int Pieces { get; set; }

    public string ParentuniqueNo { get; set; } = null!;
}
