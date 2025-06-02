using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpHarmonizedCodesImport
{
    public string Partno { get; set; } = null!;

    public string HarmonizedTariff { get; set; } = null!;

    public string CustomsUomcode { get; set; } = null!;
}
