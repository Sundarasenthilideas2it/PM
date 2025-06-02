using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsbarcodesImported20201213
{
    public long? Invseriid { get; set; }

    public short SessionId { get; set; }

    public DateTime UdpateTime { get; set; }

    public int IsInsert { get; set; }

    public int IsUpdate { get; set; }

    public int IsDelete { get; set; }

    public string? Partno { get; set; }

    public string? SerialNo { get; set; }

    public string? BarcodeToImport { get; set; }

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string? Bld { get; set; }

    public string Row { get; set; } = null!;

    public int Onhand { get; set; }

    public string Acctno { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public int RemoveNonCoded { get; set; }

    public string Ponumber { get; set; } = null!;

    public int ShoudLinkChildParts { get; set; }
}
