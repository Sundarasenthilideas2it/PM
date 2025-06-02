using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muuserprt
{
    public string Username { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string Cmndlineparam { get; set; } = null!;

    public int Prtseqno { get; set; }

    public int LinesPerPage { get; set; }

    public int NumberOfCopies { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
