using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AmpOutput
{
    public int AmpOutputNumber { get; set; }

    public virtual ICollection<AmpChannelCorrectionCurf> AmpChannelCorrectionCurves { get; set; } = new List<AmpChannelCorrectionCurf>();
}
