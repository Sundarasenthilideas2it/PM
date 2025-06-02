using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BudgetCategory
{
    public string CategoryCode { get; set; } = null!;

    public string CategoryDesc { get; set; } = null!;

    public virtual ICollection<Apexpcode> Apexpcodes { get; set; } = new List<Apexpcode>();
}
