using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class HtmlReportTemplateSection
{
    public int IdTemplate { get; set; }

    public int IdHtmlBlock { get; set; }

    public double SortOrder { get; set; }

    public virtual HtmlReportBlock IdHtmlBlockNavigation { get; set; } = null!;

    public virtual HtmlReportTemplate IdTemplateNavigation { get; set; } = null!;
}
