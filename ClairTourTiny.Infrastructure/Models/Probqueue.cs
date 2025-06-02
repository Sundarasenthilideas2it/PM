using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Probqueue
{
    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string Frompartentityno { get; set; } = null!;

    public string Lastentityno { get; set; } = null!;

    public string Lastwarehouse { get; set; } = null!;

    public string Inproject { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string Exctype { get; set; } = null!;

    public DateTime Trandate { get; set; }

    public string Sessionid { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
