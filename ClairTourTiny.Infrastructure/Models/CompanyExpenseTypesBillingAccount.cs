using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CompanyExpenseTypesBillingAccount
{
    public string CompanyCd { get; set; } = null!;

    public string ExpenseCd { get; set; } = null!;

    public string AccountCd { get; set; } = null!;
}
