using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Language
{
    public string Languagecd { get; set; } = null!;

    public string LanguageDesc { get; set; } = null!;

    public virtual ICollection<Peemployee> Empnos { get; set; } = new List<Peemployee>();
}
