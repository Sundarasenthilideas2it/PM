using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingItemsA
{
    public string? BidEntityno { get; set; }

    public short? Itemno { get; set; }

    public string? EquipmentEntityno { get; set; }

    public string? ExpenseEntityno { get; set; }

    public int? ExpenseSeqno { get; set; }

    public string? CrewEntityno { get; set; }

    public int? CrewEmplineNo { get; set; }

    public double? NominalDailyRate { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
