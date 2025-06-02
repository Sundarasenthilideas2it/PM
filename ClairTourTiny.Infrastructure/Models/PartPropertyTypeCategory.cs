using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartPropertyTypeCategory
{
    public int IdCategory { get; set; }

    public string CategoryDesc { get; set; } = null!;

    public virtual ICollection<PartPropertyType> PartPropertyTypes { get; set; } = new List<PartPropertyType>();
}
