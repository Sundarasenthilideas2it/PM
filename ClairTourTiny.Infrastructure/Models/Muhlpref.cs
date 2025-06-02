using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muhlpref
{
    public string Formname { get; set; } = null!;

    public string Menuname { get; set; } = null!;

    public string Fieldname { get; set; } = null!;

    public string Colname { get; set; } = null!;

    public string Formref { get; set; } = null!;

    public string Menuref { get; set; } = null!;

    public string Fieldref { get; set; } = null!;

    public string Colref { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
