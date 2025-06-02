using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproCompany
{
    public string SysproCompanyCd { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
}
