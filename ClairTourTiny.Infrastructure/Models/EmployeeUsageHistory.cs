using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeUsageHistory
{
    public string Name { get; set; } = null!;

    public string Empname { get; set; } = null!;

    public string? Email { get; set; }

    public string OwnerEntity { get; set; } = null!;

    public string WarehouseEntity { get; set; } = null!;

    public int? EmployeeMaintenance { get; set; }

    public int? CrewPayrollReport { get; set; }

    public int? CrewTools { get; set; }

    public int? CrewTraining { get; set; }

    public int? PartMaintenance { get; set; }

    public int? AddInventory { get; set; }

    public int? DeviceMaintenance { get; set; }

    public int? ProjectMaintenance { get; set; }

    public int? QuoteContractReport { get; set; }

    public int? TouringInvoiceBuilder { get; set; }

    public int? RequestForInvoicingInquiry { get; set; }

    public int? JobCosting { get; set; }

    public int? ContactMaintenance { get; set; }

    public int? CanEditProjects { get; set; }

    public int? CanSeeBids { get; set; }

    public int? CanSeeInvoicing { get; set; }

    public int? CanCreateInvoices { get; set; }

    public int? CanEditPartSubhires { get; set; }

    public int? CanEditEmployee { get; set; }

    public int? CanSeeEmpRates { get; set; }

    public int? CanEditEmpMedicalInfo { get; set; }

    public int? CanSeeEmpReviews { get; set; }

    public int? CanEditParts { get; set; }

    public int? CanChangePartNumbers { get; set; }

    public int? CanEditInventory { get; set; }

    public int? CanEditPurchaseOrders { get; set; }

    public int? CanViewPurchaseOrders { get; set; }

    public int? CanEditEmployeeRate { get; set; }

    public int? CanEditVendors { get; set; }

    public int? CanEditSubhire { get; set; }

    public int? IsSysadmin { get; set; }

    public DateTime? LastProjectMaintenanceUse { get; set; }

    public DateTime? LastPartMaintenanceUse { get; set; }

    public DateTime? LastInventoryMaintenanceUse { get; set; }

    public DateTime? LastEmployeeMaintenanceUse { get; set; }

    public DateTime UserCreationDate { get; set; }

    public DateTime? LastFinesseUse { get; set; }

    public string? JobTypes { get; set; }
}
