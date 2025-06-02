using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportHtmlBlocksSummary
{
    public int IdHtmlBlock { get; set; }

    public int Seqno { get; set; }

    public string ColumnName { get; set; } = null!;

    public string SummaryType { get; set; } = null!;

    public virtual QuoteReportHtmlBlocksGroupBy QuoteReportHtmlBlocksGroupBy { get; set; } = null!;
}
