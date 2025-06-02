using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Transport
{
    public string Method { get; set; } = null!;

    public int? Sortorder { get; set; }

    public int IdLanguage { get; set; }

    public virtual XlatLanguage IdLanguageNavigation { get; set; } = null!;
}
