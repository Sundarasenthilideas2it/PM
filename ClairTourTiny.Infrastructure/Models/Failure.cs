using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Failure
{
    public int FailureId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<CabinetComponent> CabinetComponents { get; set; } = new List<CabinetComponent>();

    public virtual ICollection<Cabinet> Partnos { get; set; } = new List<Cabinet>();
}
