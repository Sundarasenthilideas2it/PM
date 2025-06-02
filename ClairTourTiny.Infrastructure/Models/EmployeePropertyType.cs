using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeePropertyType
{
    public int IdPropertyType { get; set; }

    public int IdCategory { get; set; }

    public string PropertyTypeDescription { get; set; } = null!;

    public string PropertyTypeShortDesc { get; set; } = null!;

    public virtual ICollection<EmployeeProperty> EmployeeProperties { get; set; } = new List<EmployeeProperty>();

    public virtual EmployeePropertyTypeCategory IdCategoryNavigation { get; set; } = null!;
}
