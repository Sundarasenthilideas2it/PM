using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Supplier
{
    public string VendorNo { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? BuyerCode { get; set; }

    public string? CurrencyCode { get; set; }

    public string? SuppGrp { get; set; }

    public decimal? AdditionalCostAmount { get; set; }

    public string? Contact { get; set; }

    public string CrCheck { get; set; } = null!;

    public DateOnly? CrDate { get; set; }

    public string? CrNoteText { get; set; }

    public DateOnly? DateDel { get; set; }

    public decimal? Discount { get; set; }

    public string? NoteText { get; set; }

    public string? OurCustomerNo { get; set; }

    public string PackListFlag { get; set; } = null!;

    public string PurchOrderFlag { get; set; } = null!;

    public string QcApproval { get; set; } = null!;

    public DateOnly? QcDate { get; set; }

    public DateOnly? QcAudit { get; set; }

    public string? QcNoteText { get; set; }

    public int? OrdConfRemInterval { get; set; }

    public int? DeliveryRemInterval { get; set; }

    public int? DaysBeforeDelivery { get; set; }

    public int? DaysBeforeArrival { get; set; }

    public string OrdConfReminder { get; set; } = null!;

    public string DeliveryReminder { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string? AcquisitionSite { get; set; }

    public string? Company { get; set; }

    public string? PayTermId { get; set; }

    public string? EdiAutoApprovalUser { get; set; }

    public string? QcType { get; set; }

    public DateOnly? EnvironmentDate { get; set; }

    public string? EnvironmentType { get; set; }

    public string EnvironmentalApproval { get; set; } = null!;

    public DateOnly? EnvironmentAudit { get; set; }

    public string? EnvironmentNoteText { get; set; }

    public string CocApproval { get; set; } = null!;

    public DateOnly? CocDate { get; set; }

    public string? CocType { get; set; }

    public DateOnly? CocAudit { get; set; }

    public string? CocNoteText { get; set; }

    public string? CustomerNo { get; set; }

    public int? NoteId { get; set; }

    public string? SupplierTemplateDesc { get; set; }

    public string TemplateSupplier { get; set; } = null!;

    public string QuickRegisteredSupplier { get; set; } = null!;

    public string BlanketDate { get; set; } = null!;

    public string ExpressOrderAllowed { get; set; } = null!;

    public string? EdiPriCatAppUser { get; set; }

    public string PricatAutomaticApproval { get; set; } = null!;

    public string? AutomaticReplChange { get; set; }

    public string? SendChangeMessage { get; set; }

    public string ReceiptRefReminder { get; set; } = null!;

    public string PrintAmountsInclTax { get; set; } = null!;

    public double? ClosingDay { get; set; }

    public string? EndOfMonth { get; set; }

    public string ReceivingAdviceType { get; set; } = null!;

    public string RecAdvSelfBilling { get; set; } = null!;

    public string? ClassificationStandard { get; set; }

    public string? PurchaseCode { get; set; }

    public string PoChangeManagement { get; set; } = null!;

    public string CreateConfirmationChgOrd { get; set; } = null!;

    public string EmailPurchaseOrder { get; set; } = null!;

    public string? VendorCategoryDb { get; set; }

    public string DirDelApproval { get; set; } = null!;

    public string OrderConfApproval { get; set; } = null!;

    public string OrderConfDiffApproval { get; set; } = null!;

    public string AdhocPurRqstApproval { get; set; } = null!;

    public string TaxLiability { get; set; } = null!;

    public string B2bConfOrderWithDiff { get; set; } = null!;

    public string? QualitySystemLevelId { get; set; }

    public string? QualityAuditId { get; set; }

    public string? EnvironmentAuditId { get; set; }

    public string? CocAuditId { get; set; }

    public string RecAdvSbConsignment { get; set; } = null!;

    public string? RecAdvSbConsignmentDb { get; set; }

    public string RecAdvSbMixOwnership { get; set; } = null!;

    public string? RecAdvSbMixOwnershipDb { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }
}
