using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Mulistviewsort
{
    public string Formname { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public int SortNo { get; set; }

    public string Itemname { get; set; } = null!;

    public string AscDesc { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
