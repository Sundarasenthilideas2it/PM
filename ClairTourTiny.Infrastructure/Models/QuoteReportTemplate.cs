using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportTemplate
{
    public int IdTemplate { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? PrivateUsername { get; set; }
}
