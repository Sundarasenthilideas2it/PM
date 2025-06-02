using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReferenceSetCurve
{
    public int MetaDataVersionNumberValidFrom { get; set; }

    public int? MetaDataVersionNumberValidTo { get; set; }

    public int ReferenceSetId { get; set; }

    public int CurveId { get; set; }

    public int DeterminationId { get; set; }

    public bool IndicatesPolarityFailure { get; set; }

    public bool? IsReferenceGood { get; set; }

    public virtual ComplexCurve Curve { get; set; } = null!;

    public virtual MetaDataVersion MetaDataVersionNumberValidFromNavigation { get; set; } = null!;

    public virtual MetaDataVersion? MetaDataVersionNumberValidToNavigation { get; set; }

    public virtual ReferenceSet1 ReferenceSet { get; set; } = null!;

    public virtual ReferenceSetDetermination ReferenceSetDetermination { get; set; } = null!;
}
