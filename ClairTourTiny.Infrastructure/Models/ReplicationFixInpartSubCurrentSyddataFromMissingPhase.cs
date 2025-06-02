using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReplicationFixInpartSubCurrentSyddataFromMissingPhase
{
    public string Partno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Row { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int Onhand { get; set; }

    public DateTime Receipt { get; set; }

    public string Parentpartno { get; set; } = null!;

    public string ParentuniqueNo { get; set; } = null!;

    public string ParentserialNo { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public int HeldInWarehouse { get; set; }
}
