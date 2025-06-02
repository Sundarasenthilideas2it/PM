using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IntegrationProjectExpenseGlCodeCostBucket
{
    public string ExpenseGlCode { get; set; } = null!;

    public string? CostBucketCode { get; set; }

    public virtual IntegrationProjectCostBucket? CostBucketCodeNavigation { get; set; }
}
