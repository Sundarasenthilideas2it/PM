using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Outcome
{
    public int OutcomeId { get; set; }

    public bool IsPass { get; set; }

    public bool? IsFail { get; set; }

    public virtual ICollection<ReferenceSetDetermination> ReferenceSetDeterminations { get; set; } = new List<ReferenceSetDetermination>();
}
