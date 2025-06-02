using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartTranslation
{
    public string Partno { get; set; } = null!;

    public int IdLanguage { get; set; }

    public string Partdesc { get; set; } = null!;

    public virtual XlatLanguage IdLanguageNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
