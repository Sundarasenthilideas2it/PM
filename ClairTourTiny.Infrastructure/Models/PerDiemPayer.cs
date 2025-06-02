using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PerDiemPayer
{
    public string Payer { get; set; } = null!;

    public int? Sortorder { get; set; }
}
