using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RackConfiguratorPartsToDelete
{
    public short SessionId { get; set; }

    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;
}
