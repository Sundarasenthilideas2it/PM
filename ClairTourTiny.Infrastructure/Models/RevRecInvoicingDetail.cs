using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecInvoicingDetail
{
    public string Entityno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public double? ActualInvoiceEquipmentBeforeCutoff { get; set; }

    public double? ActualInvoiceEquipment { get; set; }

    public double? ActualInvoiceMixedLaborBeforeCutoff { get; set; }

    public double? ActualInvoiceMixedLabor { get; set; }

    public double? ActualInvoiceSubLaborBeforeCutoff { get; set; }

    public double? ActualInvoiceSubLabor { get; set; }

    public double? ActualInvoiceEmpLaborBeforeCutoff { get; set; }

    public double? ActualInvoiceEmpLabor { get; set; }

    public double? ActualInvoiceExpensesBeforeCutoff { get; set; }

    public double? ActualInvoiceExpenses { get; set; }

    public virtual Glaccount AcctcdNavigation { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
