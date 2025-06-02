using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muhlpfld
{
    public string Formname { get; set; } = null!;

    public string Menuname { get; set; } = null!;

    public string Fieldname { get; set; } = null!;

    public string Colname { get; set; } = null!;

    public int Noteseq { get; set; }

    public string Subname { get; set; } = null!;

    public string Helptext { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
