public class ProjectRfiModel
{
    public string EntityNo { get; set; } = string.Empty;
    public string InvEntityNo { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Days { get; set; }
    public decimal Rate { get; set; }
    public string RateType { get; set; } = string.Empty;
    public double Total { get; set; }
    public string Note { get; set; } = string.Empty;
    public int SeqNo { get; set; }
    public string PostInd { get; set; } = string.Empty;
    public string AeApproved { get; set; } = string.Empty;
    public string AmApproved { get; set; } = string.Empty;
    public string BillSchedule { get; set; } = string.Empty;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; }
    public string ModifiedBy { get; set; } = string.Empty;
    public DateTime DateModified { get; set; }
    public string? AccountCode { get; set; }
    public DateTime? InvoicedThrough { get; set; }
    public double TotalInvoiced { get; set; }
    public string? RevenueCompany { get; set; }
    public bool IsManualAdjustment { get; set; }
}
