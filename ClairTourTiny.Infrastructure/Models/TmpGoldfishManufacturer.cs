using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpGoldfishManufacturer
{
    public int IMakeId { get; set; }

    public string? SMakeName { get; set; }

    public DateTime? DtLastMod { get; set; }

    public string? SLastUser { get; set; }
}
