using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SoundImageRackIdtoEntitynoMapping
{
    public string Entityno { get; set; } = null!;

    public int? IEquipRef { get; set; }

    public int? ITourRef { get; set; }

    public int? IRackTypeRef { get; set; }

    public int? IRackNo { get; set; }

    public string SRackSuffix { get; set; } = null!;

    public string SCaseStencil { get; set; } = null!;
}
