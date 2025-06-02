using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BidProjectPartLatestChange
{
    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public DateTime? OldStartDate { get; set; }

    public DateTime? OldEndDate { get; set; }

    public int? OldQty { get; set; }

    public DateTime? NewStartDate { get; set; }

    public DateTime? NewEndDate { get; set; }

    public int? NewQty { get; set; }

    public string? Userid { get; set; }

    public DateTime? Changedate { get; set; }

    public string? ProjectWarehouse { get; set; }

    public DateTime? DisplayStartDate { get; set; }

    public DateTime? DisplayEndDate { get; set; }
}
