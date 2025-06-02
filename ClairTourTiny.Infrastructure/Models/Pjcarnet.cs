using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pjcarnet
{
    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string MaterialDesc { get; set; } = null!;

    public string Partrev { get; set; } = null!;

    public string Partentityno { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Width { get; set; } = null!;

    public string Depth { get; set; } = null!;

    public string Length { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public double Projpercent { get; set; }

    public double Qty { get; set; }

    public int Seqno { get; set; }

    public int Subitem { get; set; }

    public double Cost { get; set; }

    public int Itemtype { get; set; }

    public int Subtype { get; set; }

    public string Userid { get; set; } = null!;

    public string Usertime { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
