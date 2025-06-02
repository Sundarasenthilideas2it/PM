using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartPropertyType
{
    public int IdPropertyType { get; set; }

    public int IdCategory { get; set; }

    public string PropertyTypeDescription { get; set; } = null!;

    public string PropertyTypeShortDesc { get; set; } = null!;

    public int? DeviceIdPropertyType { get; set; }

    public virtual PartPropertyTypeCategory IdCategoryNavigation { get; set; } = null!;

    public virtual ICollection<PartProperty1> PartProperty1s { get; set; } = new List<PartProperty1>();
}
