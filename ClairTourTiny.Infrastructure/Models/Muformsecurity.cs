using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muformsecurity
{
    public string Formname { get; set; } = null!;

    public string Fieldname { get; set; } = null!;

    public string Colname { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string GroupRole { get; set; } = null!;

    public string NotVisibleEnabled { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
