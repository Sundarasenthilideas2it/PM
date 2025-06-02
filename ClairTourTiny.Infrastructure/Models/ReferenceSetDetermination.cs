using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReferenceSetDetermination
{
    public int ReferenceSetId { get; set; }

    public int DeterminationId { get; set; }

    public string DisplayText { get; set; } = null!;

    public int OutcomeId { get; set; }

    public virtual Outcome Outcome { get; set; } = null!;

    public virtual ReferenceSet1 ReferenceSet { get; set; } = null!;

    public virtual ICollection<ReferenceSetCurve> ReferenceSetCurves { get; set; } = new List<ReferenceSetCurve>();
}
