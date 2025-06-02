using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SqlresultType
{
    public string ResultTypeCode { get; set; } = null!;

    public string ResultType { get; set; } = null!;

    public virtual ICollection<HtmlReportBlock> HtmlReportBlocks { get; set; } = new List<HtmlReportBlock>();

    public virtual ICollection<HtmlReportBlocksArchive> HtmlReportBlocksArchives { get; set; } = new List<HtmlReportBlocksArchive>();

    public virtual ICollection<QuoteReportHtmlBlock> QuoteReportHtmlBlocks { get; set; } = new List<QuoteReportHtmlBlock>();
}
