using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TempPoLine
{
    public string? OrderNo { get; set; }

    public string? PartNo { get; set; }

    public string? LineNo { get; set; }

    public string? ReleaseNo { get; set; }

    public string? Description { get; set; }

    public decimal? BuyQtyDue { get; set; }

    public decimal? InvQtyArrived { get; set; }
}
