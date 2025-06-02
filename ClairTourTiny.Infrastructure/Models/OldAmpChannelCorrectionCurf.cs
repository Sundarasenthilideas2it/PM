using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OldAmpChannelCorrectionCurf
{
    public string AmpBarcode { get; set; } = null!;

    public int AmpOutputNumber { get; set; }

    public int AmpPowerChannelIrid { get; set; }

    public int BreakInVoltageCorrectionIrid { get; set; }

    public int BreakInCurrentCorrectionIrid { get; set; }
}
