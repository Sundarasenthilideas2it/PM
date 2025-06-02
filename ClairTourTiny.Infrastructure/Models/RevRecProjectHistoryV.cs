using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecProjectHistoryV
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

    public double? SubToMixedFraction { get; set; }

    public double? EmpToMixedFraction { get; set; }

    public double? BidCostSubLaborBeforeCutoff { get; set; }

    public double? BidCostSubLabor { get; set; }

    public double? BidCostEmpLaborBeforeCutoff { get; set; }

    public double? BidCostEmpLabor { get; set; }

    public double? ActualInvoiceSubLaborBeforeCutoff { get; set; }

    public double? ActualInvoiceSubLabor { get; set; }

    public double? ActualInvoiceEmpLaborBeforeCutoff { get; set; }

    public double? ActualInvoiceEmpLabor { get; set; }

    public double? ActualInvoiceSubFraction { get; set; }

    public double? ActualInvoiceEmpFraction { get; set; }

    public double? ActualInvoiceEquipmentFraction { get; set; }

    public double? ActualInvoiceExpensesFraction { get; set; }

    public double? TotalBidCost { get; set; }

    public double? BidCostSubFraction { get; set; }

    public double? BidCostEmpFraction { get; set; }

    public double? BidCostEquipmentFraction { get; set; }

    public double? BidCostExpensesFraction { get; set; }

    public double? SubFraction { get; set; }

    public double? EmpFraction { get; set; }

    public double? EquipmentFraction { get; set; }

    public double? ExpensesFraction { get; set; }

    public double? BidInvoiceSubLaborBeforeCutoff { get; set; }

    public double? BidInvoiceSubLabor { get; set; }

    public double? BidInvoiceEmpLaborBeforeCutoff { get; set; }

    public double? BidInvoiceEmpLabor { get; set; }

    public double? MaxEquipmentCost { get; set; }

    public double? MaxEquipmentCostBeforeCutoff { get; set; }

    public double? MaxSubLaborCost { get; set; }

    public double? MaxSubLaborCostBeforeCutoff { get; set; }

    public double? MaxEmpLaborCost { get; set; }

    public double? MaxEmpLaborCostBeforeCutoff { get; set; }

    public double? MaxExpensesCost { get; set; }

    public double? MaxExpensesCostBeforeCutoff { get; set; }

    public string? MaxEquipmentCostValueToUse { get; set; }

    public string? MaxSubLaborCostValueToUse { get; set; }

    public string? MaxEmpLaborCostValueToUse { get; set; }

    public string? MaxExpensesCostValueToUse { get; set; }

    public double? MaxEquipmentInvoice { get; set; }

    public double? MaxEquipmentInvoiceBeforeCutoff { get; set; }

    public double? MaxSubLaborInvoice { get; set; }

    public double? MaxSubLaborInvoiceBeforeCutoff { get; set; }

    public double? MaxEmpLaborInvoice { get; set; }

    public double? MaxEmpLaborInvoiceBeforeCutoff { get; set; }

    public double? MaxExpensesInvoice { get; set; }

    public double? MaxExpensesInvoiceBeforeCutoff { get; set; }

    public string? MaxEquipmentInvoiceValueToUse { get; set; }

    public string? MaxSubLaborInvoiceValueToUse { get; set; }

    public string? MaxEmpLaborInvoiceValueToUse { get; set; }

    public string? MaxExpensesInvoiceValueToUse { get; set; }

    public string ValueToUse { get; set; } = null!;

    public string? CogsEquipment { get; set; }

    public string? CogsSubcontract { get; set; }

    public string? CogsLabor { get; set; }

    public string? CogsExpenses { get; set; }

    public string? AppliedEquipment { get; set; }

    public string? AppliedSubcontract { get; set; }

    public string? AppliedLabor { get; set; }

    public string? AppliedExpenses { get; set; }

    public string? ActualInvoiceEquipment1 { get; set; }

    public string? ActualInvoiceSubcontract { get; set; }

    public string? ActualInvoiceLabor { get; set; }

    public string? ActualInvoiceExpenses1 { get; set; }

    public string? SAndSEquipment { get; set; }

    public string? SAndSSubcontract { get; set; }

    public string? SAndSLabor { get; set; }

    public string? SAndSExpenses { get; set; }
}
