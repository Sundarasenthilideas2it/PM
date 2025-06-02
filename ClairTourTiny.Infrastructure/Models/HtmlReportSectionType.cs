using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class HtmlReportSectionType
{
    public string IdSectionType { get; set; } = null!;

    public string SectionType { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ICollection<HtmlReportBlock> HtmlReportBlocks { get; set; } = new List<HtmlReportBlock>();

    public virtual ICollection<HtmlReportBlocksArchive> HtmlReportBlocksArchives { get; set; } = new List<HtmlReportBlocksArchive>();
}
