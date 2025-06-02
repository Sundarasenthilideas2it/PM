using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsprojectStatusMapping
{
    public decimal? Lookupcode { get; set; }

    public string? Lookuptypedescription { get; set; }

    public string StatusCode { get; set; } = null!;
}
