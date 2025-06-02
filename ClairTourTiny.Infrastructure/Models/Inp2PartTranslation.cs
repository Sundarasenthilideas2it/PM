using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Inp2PartTranslation
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public string Partno { get; set; } = null!;

    public int IdLanguage { get; set; }

    public string? Partdesc { get; set; }
}
