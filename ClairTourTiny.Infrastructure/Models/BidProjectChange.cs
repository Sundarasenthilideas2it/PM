using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BidProjectChange
{
    public string Entityno { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string? ProjectWarehouse { get; set; }

    public DateTime? OldProjectStartdate { get; set; }

    public DateTime? NewProjectStartdate { get; set; }

    public DateTime? OldProjectEnddate { get; set; }

    public DateTime? NewProjectEnddate { get; set; }

    public string? OldEngactivecd { get; set; }

    public string? NewEngactivecd { get; set; }

    public DateTime ChangeDate { get; set; }
}
