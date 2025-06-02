using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeDataSheetPropertiesV
{
    public string Empno { get; set; } = null!;

    public int IdPropertyType { get; set; }

    public string? Note { get; set; }

    public string PropertyTypeDescription { get; set; } = null!;

    public int Seqno { get; set; }

    public string Value { get; set; } = null!;
}
