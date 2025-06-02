using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AvailMultipartGroup1
{
    public string Userid { get; set; } = null!;

    public string Partgroup { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int Partseq { get; set; }

    public bool? Partactive { get; set; }

    public virtual Inpart PartnoNavigation { get; set; } = null!;

    public virtual Pjtfrusr User { get; set; } = null!;
}
