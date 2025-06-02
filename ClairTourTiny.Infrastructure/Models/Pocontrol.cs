using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pocontrol
{
    public string Company { get; set; } = null!;

    public int Quoteno { get; set; }

    public int Blanketno { get; set; }

    public int ReqnoOld { get; set; }

    public int OrdernoOld { get; set; }

    public string Accttype { get; set; } = null!;

    public string Acctno { get; set; } = null!;
}
