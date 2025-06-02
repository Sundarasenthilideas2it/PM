using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeCompanyStatus
{
    public string StatusCode { get; set; } = null!;

    public string StatusDesc { get; set; } = null!;

    public byte? DisplayOrder { get; set; }
}
