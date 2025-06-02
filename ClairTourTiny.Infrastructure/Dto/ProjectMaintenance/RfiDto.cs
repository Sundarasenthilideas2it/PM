using System.ComponentModel.DataAnnotations.Schema;

public class RfiDto
{
    [Column("entityno")]
    public string EntityNo { get; set; } = string.Empty;

    [Column("inv_entityno")]
    public string InvEntityNo { get; set; } = string.Empty;

    [Column("description")]
    public string? Description { get; set; }

    [Column("startdate")]
    public DateTime StartDate { get; set; }

    [Column("enddate")]
    public DateTime EndDate { get; set; }

    [Column("days")]
    public int Days { get; set; }

    [Column("rate")]
    public decimal Rate { get; set; }

    [Column("ratetype")]
    public string RateType { get; set; } = string.Empty;

    [Column("total")]
    public double Total { get; set; }

    [Column("note")]
    public string Note { get; set; } = string.Empty;

    [Column("seqno")]
    public int SeqNo { get; set; }

    [Column("postind")]
    public string PostInd { get; set; } = string.Empty;

    [Column("ae_approved")]
    public string AeApproved { get; set; } = string.Empty;

    [Column("am_approved")]
    public string AmApproved { get; set; } = string.Empty;

    [Column("billschedule")]
    public string BillSchedule { get; set; } = string.Empty;

    [Column("createdBy")]
    public string CreatedBy { get; set; } = string.Empty;

    [Column("dateCreated")]
    public DateTime DateCreated { get; set; }

    [Column("modifiedBy")]
    public string ModifiedBy { get; set; } = string.Empty;

    [Column("dateModified")]
    public DateTime DateModified { get; set; }

    [Column("acctcd")]
    public string? AccountCode { get; set; }

    [Column("InvoicedThrough")]
    public DateTime? InvoicedThrough { get; set; }

    [Column("TotalInvoiced")]
    public double TotalInvoiced { get; set; }

    [Column("RevenueCompany")]
    public string? RevenueCompany { get; set; }

    [Column("IsManualAdjustment")]
    public bool IsManualAdjustment { get; set; }
}
