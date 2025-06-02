using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportVaultHtmlelement
{
    public string Entityno { get; set; } = null!;

    public int Revision { get; set; }

    public int IdReporttype { get; set; }

    public int IdHtmlblock { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual QuoteReportHtmlBlock IdHtmlblockNavigation { get; set; } = null!;

    public virtual QuoteReportType IdReporttypeNavigation { get; set; } = null!;
}
