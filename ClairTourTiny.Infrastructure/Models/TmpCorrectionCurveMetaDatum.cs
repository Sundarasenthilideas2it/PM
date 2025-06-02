using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpCorrectionCurveMetaDatum
{
    public string? Barcode { get; set; }

    public int? AmpOutputNumber { get; set; }

    public int? BreakInVoltageCorrectionIrid { get; set; }

    public int? BreakInCurrentCorrectionIrid { get; set; }
}
