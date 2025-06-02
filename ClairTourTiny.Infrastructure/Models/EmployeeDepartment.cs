using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeDepartment
{
    public int Id { get; set; }

    public string PaylocityCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SortOrder { get; set; }

    public bool PhasingOut { get; set; }

    public string DepartmentGroup { get; set; } = null!;

    public virtual ICollection<Peemployee> Peemployees { get; set; } = new List<Peemployee>();
}
