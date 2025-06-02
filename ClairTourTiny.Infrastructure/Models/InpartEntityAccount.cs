using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartEntityAccount
{
    public string Partentityno { get; set; } = null!;

    public string Acctno { get; set; } = null!;

    public string Qcacctno { get; set; } = null!;

    public string Cstacctno { get; set; } = null!;

    public bool ShowInPopup { get; set; }
}
