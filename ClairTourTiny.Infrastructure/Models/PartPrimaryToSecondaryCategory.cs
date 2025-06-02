using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartPrimaryToSecondaryCategory
{
    public string PrimaryCategoryCode { get; set; } = null!;

    public string SecondaryCategoryCode { get; set; } = null!;

    public virtual PartPrimaryCategory PrimaryCategoryCodeNavigation { get; set; } = null!;
}
