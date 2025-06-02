using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IntegrationProjectJobTypeCostBucket
{
    public string Jobtype { get; set; } = null!;

    public string? CostBucketCode { get; set; }

    public virtual IntegrationProjectCostBucket? CostBucketCodeNavigation { get; set; }

    public virtual Pejob JobtypeNavigation { get; set; } = null!;
}
