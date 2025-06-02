using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public class Pm2BidRevenue
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Entityno { get; set; } = null!;

    public int Seqno { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public double Amount { get; set; }
}
