using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IsoLanguageDef
{
    public string LanguageCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? DbDescription { get; set; }

    public string? UsedInAppl { get; set; }

    public int? Objid { get; set; }

    public int? Objversion { get; set; }

    public string? Objkey { get; set; }

    public int? FinesseLanguageId { get; set; }

    public virtual XlatLanguage? FinesseLanguage { get; set; }
}
