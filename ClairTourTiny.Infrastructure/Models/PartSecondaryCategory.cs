using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartSecondaryCategory
{
    public string SecondaryCategoryCode { get; set; } = null!;

    public string SecondaryCategoryDesc { get; set; } = null!;

    public string? PrimaryCategoryCode { get; set; }

    public string Commodity { get; set; } = null!;

    public Guid FileStorageGuid { get; set; }

    public virtual Incommodity CommodityNavigation { get; set; } = null!;
}
