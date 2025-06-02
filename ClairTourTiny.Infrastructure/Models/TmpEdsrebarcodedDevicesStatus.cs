using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsrebarcodedDevicesStatus
{
    public long? Invseriid { get; set; }

    public string? Serialnum { get; set; }

    public string? Additionalassetid { get; set; }

    public string? Binnumber { get; set; }

    public string? Verifiedby { get; set; }

    public DateTime? Scandate { get; set; }
}
