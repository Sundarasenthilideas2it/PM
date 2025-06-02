using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ExpenseCategory
{
    public string CategoryCode { get; set; } = null!;

    public string CategoryDesc { get; set; } = null!;
}
