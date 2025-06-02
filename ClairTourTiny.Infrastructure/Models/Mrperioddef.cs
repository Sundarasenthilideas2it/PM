using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Mrperioddef
{
    public int PeriodNo { get; set; }

    public int Length { get; set; }

    public int PrevLength { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
