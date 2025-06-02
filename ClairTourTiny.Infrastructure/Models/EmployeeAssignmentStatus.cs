using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeAssignmentStatus
{
    public string StatusCode { get; set; } = null!;

    public string StatusDesc { get; set; } = null!;

    public byte? DisplayOrder { get; set; }

    public virtual ICollection<Pjempassign> Pjempassigns { get; set; } = new List<Pjempassign>();
}
