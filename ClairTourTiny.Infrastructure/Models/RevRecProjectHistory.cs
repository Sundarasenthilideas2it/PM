using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecProjectHistory
{
    public DateTime ProcessingDate { get; set; }

    public string Entityno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public bool IsLocked { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public DateTime CutoffDate { get; set; }

    public DateTime FirstBillingDay { get; set; }

    public DateTime LastBillingDay { get; set; }

    public double? ActualCostSubLabor { get; set; }

    public double? ActualCostSubLaborBeforeCutoff { get; set; }

    public double? ActualCostEmpLabor { get; set; }

    public double? ActualCostEmpLaborBeforeCutoff { get; set; }

    public double? ActualCostEquipment { get; set; }

    public double? ActualCostEquipmentBeforeCutoff { get; set; }

    public double? ActualCostExpenses { get; set; }

    public double? ActualCostExpensesBeforeCutoff { get; set; }

    public double? ActualCostSubFraction { get; set; }

    public double? ActualCostEmpFraction { get; set; }

    public double? ActualCostSubFractionBeforeCutoff { get; set; }

    public double? ActualCostEmpFractionBeforeCutoff { get; set; }

    public double? AssignedSubHours { get; set; }

    public double? AssignedSubHoursBeforeCutoff { get; set; }

    public double? AssignedEmpHours { get; set; }

    public double? AssignedEmpHoursBeforeCutoff { get; set; }

    public double? AssignedSubFraction { get; set; }

    public double? AssignedEmpFraction { get; set; }

    public double? BidCostMixedLabor { get; set; }

    public double? BidCostMixedLaborBeforeCutoff { get; set; }

    public double? BidCostEquipment { get; set; }

    public double? BidCostEquipmentBeforeCutoff { get; set; }

    public double? BidCostExpenses { get; set; }

    public double? BidCostExpensesBeforeCutoff { get; set; }

    public double? ActualInvoiceMixedLabor { get; set; }

    public double? ActualInvoiceMixedLaborBeforeCutoff { get; set; }

    public double? ActualInvoiceEquipment { get; set; }

    public double? ActualInvoiceEquipmentBeforeCutoff { get; set; }

    public double? ActualInvoiceExpenses { get; set; }

    public double? ActualInvoiceExpensesBeforeCutoff { get; set; }

    public double? ActualInvoiceTotal { get; set; }

    public double? ActualInvoiceTotalBeforeCutoff { get; set; }

    public double? BidInvoiceMixedLabor { get; set; }

    public double? BidInvoiceMixedLaborBeforeCutoff { get; set; }

    public double? BidInvoiceEquipment { get; set; }

    public double? BidInvoiceEquipmentBeforeCutoff { get; set; }

    public double? BidInvoiceExpenses { get; set; }

    public double? BidInvoiceExpensesBeforeCutoff { get; set; }

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
