using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PurchaseOrderLineItemsSaveDatum
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public int? IdPurchaseOrderLineItem { get; set; }

    public int? IdPurchaseOrder { get; set; }

    public int LineItemNo { get; set; }

    public string LineItemDesc { get; set; } = null!;

    public string? Partno { get; set; }

    public string? Empno { get; set; }

    public int? Emplineno { get; set; }

    public int? Subhirelineno { get; set; }

    public DateTime? DueDate { get; set; }

    public double Qty { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? BillDays { get; set; }

    public decimal UnitRate { get; set; }

    public double DiscountPct { get; set; }

    public string? AcctCd { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? MfgpartNo { get; set; }

    public int? Ponumber { get; set; }
}
