using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportSectionType
{
    public string IdSectionType { get; set; } = null!;

    public string SectionType { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ICollection<QuoteReportHtmlBlock> QuoteReportHtmlBlocks { get; set; } = new List<QuoteReportHtmlBlock>();
}
