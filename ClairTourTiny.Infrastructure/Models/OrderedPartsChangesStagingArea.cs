using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OrderedPartsChangesStagingArea
{
    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string? OldMfgDesc { get; set; }

    public string? NewMfgDesc { get; set; }

    public int? OldEstQty { get; set; }

    public int? NewEstQty { get; set; }

    public long? TransactionId { get; set; }

    public string Userid { get; set; } = null!;

    public DateTime ChangeDate { get; set; }

    public DateTime? OldStartdate { get; set; }

    public DateTime? NewStartdate { get; set; }

    public DateTime? OldEnddate { get; set; }

    public DateTime? NewEnddate { get; set; }
}
