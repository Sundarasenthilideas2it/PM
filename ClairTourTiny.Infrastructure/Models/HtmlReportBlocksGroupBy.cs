using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class HtmlReportBlocksGroupBy
{
    public int IdHtmlBlock { get; set; }

    public int Seqno { get; set; }

    public string GroupByField { get; set; } = null!;

    public virtual ICollection<HtmlReportBlocksSummary> HtmlReportBlocksSummaries { get; set; } = new List<HtmlReportBlocksSummary>();

    public virtual HtmlReportBlock IdHtmlBlockNavigation { get; set; } = null!;
}
