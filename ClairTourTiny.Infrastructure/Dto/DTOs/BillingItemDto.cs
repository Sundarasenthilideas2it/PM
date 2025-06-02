using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

public class BillingItemDto
{
    public int Id { get; set; }
    public string EntityNo { get; set; }
    public int BillingPeriodId { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string Category { get; set; }
    public string TaxCode { get; set; }
    public decimal TaxAmount { get; set; }
    public string Status { get; set; }
    public string Notes { get; set; }
    public DateTime? BillingDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
} 