using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportHtmlBlocksGroupBy
{
    public int IdHtmlBlock { get; set; }

    public int Seqno { get; set; }

    public string GroupByField { get; set; } = null!;

    public virtual QuoteReportHtmlBlock IdHtmlBlockNavigation { get; set; } = null!;

    public virtual ICollection<QuoteReportHtmlBlocksSummary> QuoteReportHtmlBlocksSummaries { get; set; } = new List<QuoteReportHtmlBlocksSummary>();
}
