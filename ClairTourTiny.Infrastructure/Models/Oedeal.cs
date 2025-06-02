using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Oedeal
{
    public string Catalogclass { get; set; } = null!;

    public string Custclass { get; set; } = null!;

    public string DealNo { get; set; } = null!;

    public DateTime DealBegin { get; set; }

    public DateTime DealEnd { get; set; }

    public double Discount { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public string DealExplain { get; set; } = null!;

    public double MinimumQty { get; set; }

    public double MaximumQty { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
