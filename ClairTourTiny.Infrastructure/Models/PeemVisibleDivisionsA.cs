using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeemVisibleDivisionsA
{
    public string Userid { get; set; } = null!;

    public string Division { get; set; } = null!;

    public bool CanSeePayRate { get; set; }

    public bool CanEditPayRate { get; set; }

    public bool CanEditEmployee { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
