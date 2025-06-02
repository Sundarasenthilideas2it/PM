using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DevicePropertyType
{
    public int IdPropertyType { get; set; }

    public int IdCategory { get; set; }

    public string PropertyTypeDescription { get; set; } = null!;

    public string PropertyTypeShortDesc { get; set; } = null!;

    public double? SortOrder { get; set; }

    public bool IsVisible { get; set; }

    public string? Color { get; set; }

    public bool IsAllocatedIpaddressPropertyType { get; set; }

    public virtual ICollection<DeviceProperty1> DeviceProperty1s { get; set; } = new List<DeviceProperty1>();

    public virtual DevicePropertyTypeCategory IdCategoryNavigation { get; set; } = null!;
}
