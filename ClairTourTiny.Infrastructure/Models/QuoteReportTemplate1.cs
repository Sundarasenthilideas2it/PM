using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportTemplate1
{
    public int IdTemplate { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? PrivateUsername { get; set; }

    public virtual Pjtfrusr? PrivateUsernameNavigation { get; set; }

    public virtual ICollection<QuoteReportTemplateSection> QuoteReportTemplateSections { get; set; } = new List<QuoteReportTemplateSection>();
}
