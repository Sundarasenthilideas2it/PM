using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartDemandsDirection
{
    public int Direction { get; set; }

    public string WhichWarehouse { get; set; } = null!;
}
