using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportTemplateSection
{
    public int IdTemplate { get; set; }

    public int IdHtmlBlock { get; set; }

    public double SortOrder { get; set; }

    public virtual QuoteReportHtmlBlock IdHtmlBlockNavigation { get; set; } = null!;

    public virtual QuoteReportTemplate1 IdTemplateNavigation { get; set; } = null!;
}
