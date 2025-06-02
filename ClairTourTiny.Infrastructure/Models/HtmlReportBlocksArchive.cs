using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class HtmlReportBlocksArchive
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

    public DateTime ArchiveDate { get; set; }

    public string ArchivedBy { get; set; } = null!;

    public virtual Pjtfrusr ArchivedByNavigation { get; set; } = null!;

    public virtual HtmlReportSectionType IdSectionTypeNavigation { get; set; } = null!;

    public virtual SqlresultType? ResultTypeCodeNavigation { get; set; }
}
