using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IntegrationProjectCostBucket
{
    public string CostBucketCode { get; set; } = null!;

    public string CostBucketDescription { get; set; } = null!;

    public virtual ICollection<IntegrationProjectExpenseGlCodeCostBucket> IntegrationProjectExpenseGlCodeCostBuckets { get; set; } = new List<IntegrationProjectExpenseGlCodeCostBucket>();

    public virtual ICollection<IntegrationProjectJobTypeCostBucket> IntegrationProjectJobTypeCostBuckets { get; set; } = new List<IntegrationProjectJobTypeCostBucket>();
}
