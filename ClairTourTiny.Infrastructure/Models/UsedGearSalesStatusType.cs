using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UsedGearSalesStatusType
{
    public string UsedGearSalesStatusTypeCode { get; set; } = null!;

    public string UsedGearSalesStatusTypeDesc { get; set; } = null!;

    public virtual ICollection<InpartUsedGearSalesInfo> InpartUsedGearSalesInfos { get; set; } = new List<InpartUsedGearSalesInfo>();
}
