using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReportFieldTranslation
{
    public string Field { get; set; } = null!;

    public int IdLanguage { get; set; }

    public string Translation { get; set; } = null!;

    public virtual XlatLanguage IdLanguageNavigation { get; set; } = null!;
}
