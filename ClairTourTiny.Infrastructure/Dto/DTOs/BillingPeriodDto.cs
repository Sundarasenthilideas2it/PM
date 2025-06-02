using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

public class BillingPeriodDto
{
    public int Id { get; set; }
    public string EntityNo { get; set; }
    public string PeriodName { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Status { get; set; }
    public decimal TotalAmount { get; set; }
    public string Currency { get; set; }
    public string Notes { get; set; }
    public bool IsAdjusted { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; }
} 