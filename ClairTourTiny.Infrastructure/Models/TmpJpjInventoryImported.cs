using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjInventoryImported
{
    public string? ImportPartNo { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string? Dept { get; set; }

    public string Bld { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string? Row { get; set; }

    public string SerialNo { get; set; } = null!;

    public double? Qty { get; set; }

    public DateOnly? ReceiptDate { get; set; }

    public string Parentpartno { get; set; } = null!;

    public string ParentuniqueNo { get; set; } = null!;

    public string ParentserialNo { get; set; } = null!;

    public int Heldinwarehouse { get; set; }
}
