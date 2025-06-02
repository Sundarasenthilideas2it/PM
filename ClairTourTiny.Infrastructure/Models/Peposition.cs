using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Peposition
{
    public string Posno { get; set; } = null!;

    public string Empno { get; set; } = null!;

    public string Division { get; set; } = null!;

    public string Deptno { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public string Posdesc { get; set; } = null!;

    public string Mgrposno { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
