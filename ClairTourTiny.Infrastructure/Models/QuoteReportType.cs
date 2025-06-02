using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportType
{
    public int IdReporttype { get; set; }

    public string? Reporttype { get; set; }

    public virtual ICollection<QuoteReportVaultExpenseResponsibility> QuoteReportVaultExpenseResponsibilities { get; set; } = new List<QuoteReportVaultExpenseResponsibility>();

    public virtual ICollection<QuoteReportVaultHtmlelement> QuoteReportVaultHtmlelements { get; set; } = new List<QuoteReportVaultHtmlelement>();

    public virtual ICollection<QuoteReportVault> QuoteReportVaults { get; set; } = new List<QuoteReportVault>();
}
