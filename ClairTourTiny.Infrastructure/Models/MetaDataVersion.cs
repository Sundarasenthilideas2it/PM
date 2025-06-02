using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MetaDataVersion
{
    public int MetaDataVersionNumber { get; set; }

    public DateTimeOffset ValidFrom { get; set; }

    public virtual ICollection<ReferenceSetCurve> ReferenceSetCurveMetaDataVersionNumberValidFromNavigations { get; set; } = new List<ReferenceSetCurve>();

    public virtual ICollection<ReferenceSetCurve> ReferenceSetCurveMetaDataVersionNumberValidToNavigations { get; set; } = new List<ReferenceSetCurve>();

    public virtual ICollection<ReferenceSetParameter> ReferenceSetParameterMetaDataVersionNumberValidFromNavigations { get; set; } = new List<ReferenceSetParameter>();

    public virtual ICollection<ReferenceSetParameter> ReferenceSetParameterMetaDataVersionNumberValidToNavigations { get; set; } = new List<ReferenceSetParameter>();
}
