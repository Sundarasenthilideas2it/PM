using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingPeriodsA
{
    public string? BidEntityno { get; set; }

    public short? Periodno { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? PeriodTitle { get; set; }

    public bool? IsActive { get; set; }

    public bool? ShowOnQuoteReport { get; set; }

    public int? DisplayOrder { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
