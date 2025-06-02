using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartTranslationsTemp
{
    public string Partno { get; set; } = null!;

    public int IdLanguage { get; set; }

    public string Partdesc { get; set; } = null!;

    public bool? Resolved { get; set; }
}
