using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DevicePropertyTypeCategory
{
    public int IdCategory { get; set; }

    public string CategoryDesc { get; set; } = null!;

    public virtual ICollection<DevicePropertyType> DevicePropertyTypes { get; set; } = new List<DevicePropertyType>();
}
