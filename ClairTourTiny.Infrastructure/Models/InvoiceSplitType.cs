using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSplitType
{
    public string Type { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ICollection<InvoiceSplit> InvoiceSplits { get; set; } = new List<InvoiceSplit>();
}
