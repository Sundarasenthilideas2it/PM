using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecCategory
{
    public string Category { get; set; } = null!;

    public virtual ICollection<RevRecCategoryMapping> RevRecCategoryMappings { get; set; } = new List<RevRecCategoryMapping>();

    public virtual ICollection<RevRecProjectAccountBalance> RevRecProjectAccountBalances { get; set; } = new List<RevRecProjectAccountBalance>();

    public virtual ICollection<RevRecRevenueAccountBalance> RevRecRevenueAccountBalances { get; set; } = new List<RevRecRevenueAccountBalance>();

    public virtual ICollection<RevRecTempProjectAccountBalance> RevRecTempProjectAccountBalances { get; set; } = new List<RevRecTempProjectAccountBalance>();

    public virtual ICollection<RevRecTempProjectCategoryValueBreakdown> RevRecTempProjectCategoryValueBreakdowns { get; set; } = new List<RevRecTempProjectCategoryValueBreakdown>();

    public virtual ICollection<RevRecTempProjectSummaryToCategorySummary> RevRecTempProjectSummaryToCategorySummaries { get; set; } = new List<RevRecTempProjectSummaryToCategorySummary>();
}
