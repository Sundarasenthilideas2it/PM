using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReferenceSet1
{
    public int ReferenceSetId { get; set; }

    public string Partno { get; set; } = null!;

    public string? Configuration { get; set; }

    public string Component { get; set; } = null!;

    public string Test { get; set; } = null!;

    public virtual CabinetConfiguration? CabinetConfiguration { get; set; }

    public virtual Component ComponentNavigation { get; set; } = null!;

    public virtual ReferenceSetCurve? ReferenceSetCurve { get; set; }

    public virtual ICollection<ReferenceSetDetermination> ReferenceSetDeterminations { get; set; } = new List<ReferenceSetDetermination>();

    public virtual ReferenceSetParameter? ReferenceSetParameter { get; set; }

    public virtual Test TestNavigation { get; set; } = null!;
}
