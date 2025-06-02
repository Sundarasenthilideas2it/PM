using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pm2BidExpense
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Entityno { get; set; } = null!;

    public int Seqno { get; set; }

    public string Expcd { get; set; } = null!;

    public string PeriodType { get; set; } = null!;

    public string? Notes { get; set; }

    public double ItemCost { get; set; }

    public int ItemQty { get; set; }

    public string Category { get; set; } = null!;
}
