using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportHtmlBlock
{
    public int IdHtmlBlock { get; set; }

    public string? Description { get; set; }

    public string Html { get; set; } = null!;

    public string? Sqlquery { get; set; }

    public string? ResultTypeCode { get; set; }

    public double? SortOrder { get; set; }

    public int? IsVisible { get; set; }

    public int IsDefault { get; set; }

    public string IdSectionType { get; set; } = null!;

    public virtual QuoteReportSectionType IdSectionTypeNavigation { get; set; } = null!;

    public virtual ICollection<QuoteReportHtmlBlocksGroupBy> QuoteReportHtmlBlocksGroupBies { get; set; } = new List<QuoteReportHtmlBlocksGroupBy>();

    public virtual ICollection<QuoteReportTemplateSection> QuoteReportTemplateSections { get; set; } = new List<QuoteReportTemplateSection>();

    public virtual ICollection<QuoteReportVaultHtmlelement> QuoteReportVaultHtmlelements { get; set; } = new List<QuoteReportVaultHtmlelement>();

    public virtual SqlresultType? ResultTypeCodeNavigation { get; set; }
}
