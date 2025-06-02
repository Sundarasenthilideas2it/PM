using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Apexpcode
{
    public string Expcd { get; set; } = null!;

    public string Expdesc { get; set; } = null!;

    public string BudgetCategoryCode { get; set; } = null!;

    public virtual ICollection<BillingAccount> BillingAccounts { get; set; } = new List<BillingAccount>();

    public virtual BudgetCategory BudgetCategoryCodeNavigation { get; set; } = null!;

    public virtual ICollection<Pjjobexpense> Pjjobexpenses { get; set; } = new List<Pjjobexpense>();
}
