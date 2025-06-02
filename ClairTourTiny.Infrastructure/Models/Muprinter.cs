using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muprinter
{
    public int Prtseqno { get; set; }

    public string Prtdesc { get; set; } = null!;

    public string ClientOnline { get; set; } = null!;

    public string Cmndline { get; set; } = null!;

    public int LinesPerPage { get; set; }

    public int NumberOfCopies { get; set; }

    public string Prtdefault { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
