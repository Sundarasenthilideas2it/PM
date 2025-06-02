using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartPrimaryCategory
{
    public string PrimaryCategoryCode { get; set; } = null!;

    public string PrimaryCategoryDesc { get; set; } = null!;

    public virtual ICollection<PartPrimaryToSecondaryCategory> PartPrimaryToSecondaryCategories { get; set; } = new List<PartPrimaryToSecondaryCategory>();
}
