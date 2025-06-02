using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArPartsupdate021511
{
    public int IdStockType { get; set; }

    public string Number { get; set; } = null!;

    public string? CustomNumber { get; set; }

    public string Partdesc { get; set; } = null!;

    public string? Acctcd { get; set; }

    public string? Commodity { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Totmatcost4 { get; set; }

    public decimal? Totmatcost1 { get; set; }

    public decimal? LengthUom { get; set; }

    public decimal? WidthUom { get; set; }

    public decimal? DepthUom { get; set; }

    public string? Source { get; set; }

    public int Locationcd { get; set; }

    public bool? Package { get; set; }

    public string? Usercreated { get; set; }

    public string? Usermodified { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
