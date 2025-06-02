using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Peempnote
{
    public string Empno { get; set; } = null!;

    public int NoteNo { get; set; }

    public string NoteText { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
