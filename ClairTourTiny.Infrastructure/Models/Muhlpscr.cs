using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muhlpscr
{
    public string Formname { get; set; } = null!;

    public string Menuname { get; set; } = null!;

    public string Subname { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
