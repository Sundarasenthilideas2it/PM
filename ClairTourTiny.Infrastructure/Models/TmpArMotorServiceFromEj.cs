using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArMotorServiceFromEj
{
    public string Partno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public DateTime Servicedate { get; set; }

    public string Userid { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
