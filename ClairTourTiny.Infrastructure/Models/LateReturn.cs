using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class LateReturn
{
    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public int? Seqno { get; set; }

    public string? MfgDesc { get; set; }

    public int EstQty { get; set; }

    public int LineNo { get; set; }

    public DateTime Trandate { get; set; }

    public DateTime Todate { get; set; }

    public string? Entitydesc { get; set; }

    public string? OriginWarehouse { get; set; }

    public string? ReturnWarehouse { get; set; }

    public string Proptype { get; set; } = null!;

    public string Commodity { get; set; } = null!;

    public int Locationcd { get; set; }

    public string? Respempno { get; set; }

    public string? Opsmgr { get; set; }

    public string? SecondaryOpsEmpno { get; set; }
}
