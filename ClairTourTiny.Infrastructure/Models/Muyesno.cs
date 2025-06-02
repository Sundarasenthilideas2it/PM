using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muyesno
{
    public string Yesnocode { get; set; } = null!;

    public string Yesnodesc { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
