using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteExpenseResponsibility
{
    public int IdResponsibility { get; set; }

    public string Responsibility { get; set; } = null!;

    public int Sortorder { get; set; }

    public virtual ICollection<QuoteReportVaultExpenseResponsibility> QuoteReportVaultExpenseResponsibilities { get; set; } = new List<QuoteReportVaultExpenseResponsibility>();
}
