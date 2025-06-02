using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Rfi1678891320250225
{
    public string Entityno { get; set; } = null!;

    public int ChangeNo { get; set; }

    public string InvEntityno { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public int Numdays { get; set; }

    public decimal Rate { get; set; }

    public string Ratetype { get; set; } = null!;

    public double Total { get; set; }

    public string Note { get; set; } = null!;

    public string Displayind { get; set; } = null!;

    public int Seqno { get; set; }

    public string Postind { get; set; } = null!;

    public string AeApproved { get; set; } = null!;

    public string AmApproved { get; set; } = null!;

    public string Billschedule { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime DateModified { get; set; }

    public string? Acctcd { get; set; }

    public int? InvoiceTemplateId { get; set; }

    public int? InvoiceTemplateGroupId { get; set; }

    public DateTime? InvoicedThrough { get; set; }

    public string? TemplateModifiedBy { get; set; }

    public DateTime? TemplateModifiedDate { get; set; }

    public double TotalInvoiced { get; set; }

    public string? RevenueCompany { get; set; }

    public bool? FullyApproved { get; set; }

    public int? SortOrder { get; set; }

    public bool IsManualAdjustment { get; set; }

    public short? SplitCount { get; set; }

    public short? SplitCountInvoiced { get; set; }

    public bool? FullyInvoiced { get; set; }
}
