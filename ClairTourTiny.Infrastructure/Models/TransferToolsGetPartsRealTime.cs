using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TransferToolsGetPartsRealTime
{
    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string MfgDesc { get; set; } = null!;

    public int Qty { get; set; }

    public double? QuantityToSubhire { get; set; }

    public int Checkoutqty { get; set; }

    public int? Difference { get; set; }

    public int? Avail { get; set; }

    public int HeldInWarehouse { get; set; }

    public string Package { get; set; } = null!;

    public string PhaseWarehouse { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Engactivecd { get; set; } = null!;

    public int Seqno { get; set; }
}
