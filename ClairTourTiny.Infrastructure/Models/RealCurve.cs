using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RealCurve
{
    public int CurveId { get; set; }

    public virtual ICollection<AmpChannelCorrectionCurf> AmpChannelCorrectionCurfAmpPowerChannelIrs { get; set; } = new List<AmpChannelCorrectionCurf>();

    public virtual ICollection<AmpChannelCorrectionCurf> AmpChannelCorrectionCurfBreakInCurrentCorrectionIrs { get; set; } = new List<AmpChannelCorrectionCurf>();

    public virtual ICollection<AmpChannelCorrectionCurf> AmpChannelCorrectionCurfBreakInVoltageCorrectionIrs { get; set; } = new List<AmpChannelCorrectionCurf>();

    public virtual ICollection<RealCurveValue> RealCurveValues { get; set; } = new List<RealCurveValue>();
}
