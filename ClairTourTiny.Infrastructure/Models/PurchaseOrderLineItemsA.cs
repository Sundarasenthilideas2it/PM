using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PurchaseOrderLineItemsA
{
    public int? IdPurchaseOrderLineItem { get; set; }

    public int? IdPurchaseOrder { get; set; }

    public int? LineItemNo { get; set; }

    public string? LineItemDesc { get; set; }

    public string? Partno { get; set; }

    public string? Empno { get; set; }

    public int? Emplineno { get; set; }

    public int? Subhirelineno { get; set; }

    public DateOnly? DueDate { get; set; }

    public double? Qty { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double? BillDays { get; set; }

    public decimal? UnitRate { get; set; }

    public double? DiscountPct { get; set; }

    public string? AcctCd { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? MfgpartNo { get; set; }

    public int? Ponumber { get; set; }

    public DateTime AdateTime { get; set; }

    public string AuserId { get; set; } = null!;

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }
}
