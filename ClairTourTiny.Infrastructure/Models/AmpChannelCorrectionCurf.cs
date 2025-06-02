using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AmpChannelCorrectionCurf
{
    public byte[] FrameLow { get; set; } = null!;

    public byte[] FrameHigh { get; set; } = null!;

    public int AmpOutputNumber { get; set; }

    public int? AmpPowerChannelIrid { get; set; }

    public int? BreakInVoltageCorrectionIrid { get; set; }

    public int? BreakInCurrentCorrectionIrid { get; set; }

    public virtual AmpOutput AmpOutputNumberNavigation { get; set; } = null!;

    public virtual RealCurve? AmpPowerChannelIr { get; set; }

    public virtual RealCurve? BreakInCurrentCorrectionIr { get; set; }

    public virtual RealCurve? BreakInVoltageCorrectionIr { get; set; }
}
