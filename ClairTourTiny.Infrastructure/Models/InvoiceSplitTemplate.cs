using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSplitTemplate
{
    public int TemplateId { get; set; }

    public string Name { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ICollection<InvoiceSplitTemplateItem> InvoiceSplitTemplateItems { get; set; } = new List<InvoiceSplitTemplateItem>();
}
