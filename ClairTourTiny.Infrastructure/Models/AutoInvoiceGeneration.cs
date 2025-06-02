using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AutoInvoiceGeneration
{
    public string AutoInvoiceGenerationCd { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Oelocation> Oelocations { get; set; } = new List<Oelocation>();
}
