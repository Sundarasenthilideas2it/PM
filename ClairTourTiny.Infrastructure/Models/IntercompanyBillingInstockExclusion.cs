using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IntercompanyBillingInstockExclusion
{
    public string Lessor { get; set; } = null!;

    public string Lessee { get; set; } = null!;
}
