using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BarcodeNumbersChangedToday
{
    public string Dept { get; set; } = null!;

    public string OldBarcode { get; set; } = null!;

    public string NewBarcode { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public DateTime EnterDateUtc { get; set; }

    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string ParentuniqueNo { get; set; } = null!;
}
