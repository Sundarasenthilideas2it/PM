using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeProperty
{
    public string Empno { get; set; } = null!;

    public int IdPropertyType { get; set; }

    public int Seqno { get; set; }

    public string Value { get; set; } = null!;

    public string? Note { get; set; }

    public virtual Peemployee EmpnoNavigation { get; set; } = null!;

    public virtual EmployeePropertyType IdPropertyTypeNavigation { get; set; } = null!;
}
