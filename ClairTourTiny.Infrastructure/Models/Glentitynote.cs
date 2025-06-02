using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Glentitynote
{
    public string Entityno { get; set; } = null!;

    public int NoteNo { get; set; }

    public string? NoteText { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
