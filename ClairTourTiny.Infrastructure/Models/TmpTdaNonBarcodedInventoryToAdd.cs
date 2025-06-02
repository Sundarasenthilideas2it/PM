using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaNonBarcodedInventoryToAdd
{
    public string? Partno { get; set; }

    public string SerialNo { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Row { get; set; } = null!;

    public int? NonBarcodedQty { get; set; }

    public string Acctno { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public int RemoveNonCoded { get; set; }

    public string Ponumber { get; set; } = null!;

    public int ShouldLinkChildParts { get; set; }

    public string? FinessePartNo { get; set; }

    public int IdStockType { get; set; }

    public string Number { get; set; } = null!;

    public string Caption { get; set; } = null!;
}
