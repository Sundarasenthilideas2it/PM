using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpIsolvedActiveEmployeeDatum
{
    public int? Id { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? LegalCode { get; set; }

    public string? EmailAddress { get; set; }

    public string? PayGroup { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
