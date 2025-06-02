using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PejobTranslation
{
    public string Jobtype { get; set; } = null!;

    public int IdLanguage { get; set; }

    public string? Jobdesc { get; set; }

    public virtual XlatLanguage IdLanguageNavigation { get; set; } = null!;

    public virtual Pejob JobtypeNavigation { get; set; } = null!;
}
