using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeePropertyTypeCategory
{
    public int IdCategory { get; set; }

    public string CategoryDesc { get; set; } = null!;

    public bool? IsInternal { get; set; }

    public virtual ICollection<EmployeePropertyType> EmployeePropertyTypes { get; set; } = new List<EmployeePropertyType>();
}
