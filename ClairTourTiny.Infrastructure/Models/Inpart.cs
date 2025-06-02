using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Inpart
{
    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string Commmodity { get; set; } = null!;

    public string LeadSource { get; set; } = null!;

    public string Package { get; set; } = null!;

    public int Locationcd { get; set; }

    public double? LengthUom { get; set; }

    public double? DepthUom { get; set; }

    public double? WidthUom { get; set; }

    public string Acctno { get; set; } = null!;

    public string Commodity2 { get; set; } = null!;

    public string MaterialDesc { get; set; } = null!;

    public string MaterialSpecs { get; set; } = null!;

    public double Projpercent { get; set; }

    public string? Source { get; set; }

    public double Totmatcost1 { get; set; }

    public string Needkanbancard { get; set; } = null!;

    public string Needcompletionreport { get; set; } = null!;

    public string? Soundchecksequence { get; set; }

    public string? UserCreated { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UserModified { get; set; }

    public DateTime? ModifiedTime { get; set; }

    public string? PartImageFilePath { get; set; }

    public double? Ipeak120v { get; set; }

    public double? Iavg120v { get; set; }

    public double? Ipeak240v { get; set; }

    public double? Iavg240v { get; set; }

    public double? RackUnits { get; set; }

    public int? RackBays { get; set; }

    public double? OperatingVa { get; set; }

    public string? OperatingVacMin { get; set; }

    public string? OperatingVacMax { get; set; }

    public DateTime? DimsVerifiedDate { get; set; }

    public string? DimsVerifiedUser { get; set; }

    public DateTime? WeightVerifiedDate { get; set; }

    public string? WeightVerifiedUser { get; set; }

    public string? HarmonizedCode { get; set; }

    public string? HarmonizedTariff { get; set; }

    public string? FccId { get; set; }

    public string? CeMarking { get; set; }

    public string? PreferenceCriterionCode { get; set; }

    public string? ProducerCode { get; set; }

    public string? NetCostCode { get; set; }

    public bool HideOnQuotes { get; set; }

    public int? IdManufacturer { get; set; }

    public string? ModelNo { get; set; }

    public Guid Guid { get; set; }

    public string? Sku { get; set; }

    public double RentalValueUsd { get; set; }

    public string? PrimaryCategoryCode { get; set; }

    public string? SecondaryCategoryCode { get; set; }

    public string? AlternateDesc { get; set; }

    public string? RangeType { get; set; }

    public double? SafeWorkingLoadLbs { get; set; }

    public string? BarcodeLocationNote { get; set; }

    public virtual ICollection<AvailMultipartGroup1> AvailMultipartGroup1s { get; set; } = new List<AvailMultipartGroup1>();

    public virtual Cabinet? Cabinet { get; set; }

    public virtual ICollection<CloudFileStorageUploadedPartFile> CloudFileStorageUploadedPartFiles { get; set; } = new List<CloudFileStorageUploadedPartFile>();

    public virtual Incommodity CommmodityNavigation { get; set; } = null!;

    public virtual ICollection<DeviceProperty1> DeviceProperty1s { get; set; } = new List<DeviceProperty1>();

    public virtual ICollection<DisassemblePart> DisassembleParts { get; set; } = new List<DisassemblePart>();

    public virtual ICollection<EquipmentSubhire> EquipmentSubhires { get; set; } = new List<EquipmentSubhire>();

    public virtual ICollection<FileAttachmentIndex> FileAttachmentIndices { get; set; } = new List<FileAttachmentIndex>();

    public virtual ShippingHarmonizedCodeUom? HarmonizedCodeNavigation { get; set; }

    public virtual Manufacturer? IdManufacturerNavigation { get; set; }

    public virtual ICollection<InpartReference> InpartReferenceParentpartnoNavigations { get; set; } = new List<InpartReference>();

    public virtual ICollection<InpartReference> InpartReferencePartnoNavigations { get; set; } = new List<InpartReference>();

    public virtual ICollection<InpartTranslation> InpartTranslations { get; set; } = new List<InpartTranslation>();

    public virtual ICollection<InpartUsedGearSalesInfo> InpartUsedGearSalesInfos { get; set; } = new List<InpartUsedGearSalesInfo>();

    public virtual ICollection<Inpartsub> Inpartsubs { get; set; } = new List<Inpartsub>();

    public virtual ICollection<JobBudgetsPartsTransactionsTbl> JobBudgetsPartsTransactionsTbls { get; set; } = new List<JobBudgetsPartsTransactionsTbl>();

    public virtual InStorageLocation LocationcdNavigation { get; set; } = null!;

    public virtual ICollection<MergedJobBudgetsPartsTransactionsTbl> MergedJobBudgetsPartsTransactionsTbls { get; set; } = new List<MergedJobBudgetsPartsTransactionsTbl>();

    public virtual ShippingNetCostCode? NetCostCodeNavigation { get; set; }

    public virtual ICollection<PartAttachment> PartAttachments { get; set; } = new List<PartAttachment>();

    public virtual ICollection<PartBidValue> PartBidValues { get; set; } = new List<PartBidValue>();

    public virtual ICollection<PartGroupsPart> PartGroupsParts { get; set; } = new List<PartGroupsPart>();

    public virtual ICollection<PartLocationHistory> PartLocationHistories { get; set; } = new List<PartLocationHistory>();

    public virtual ICollection<PartProperty1> PartProperty1s { get; set; } = new List<PartProperty1>();

    public virtual PartSubhireNote? PartSubhireNote { get; set; }

    public virtual ICollection<PartSubhireVendor> PartSubhireVendors { get; set; } = new List<PartSubhireVendor>();

    public virtual ICollection<PartTagIdea> PartTagIdeas { get; set; } = new List<PartTagIdea>();

    public virtual ICollection<PartTransactionsExternal> PartTransactionsExternals { get; set; } = new List<PartTransactionsExternal>();

    public virtual ICollection<Pjjobbudexp> Pjjobbudexps { get; set; } = new List<Pjjobbudexp>();

    public virtual ShippingPreferenceCriterionCode? PreferenceCriterionCodeNavigation { get; set; }

    public virtual ShippingProducerCode? ProducerCodeNavigation { get; set; }

    public virtual ICollection<PurchaseOrderLineItems> PurchaseOrderLineItems { get; set; } = new List<PurchaseOrderLineItems>();

    public virtual IpAddressRange? RangeTypeNavigation { get; set; }

    public virtual ICollection<RatiogroupsFormula> RatiogroupsFormulas { get; set; } = new List<RatiogroupsFormula>();

    public virtual SoundcheckSequence? SoundchecksequenceNavigation { get; set; }

    public virtual Country? SourceNavigation { get; set; }

    public virtual ICollection<TmpAngelfishAutoSearchResult> TmpAngelfishAutoSearchResults { get; set; } = new List<TmpAngelfishAutoSearchResult>();

    public virtual ICollection<TmpAngelfishClaudeChosenPart> TmpAngelfishClaudeChosenPartGuessedPartno2Navigations { get; set; } = new List<TmpAngelfishClaudeChosenPart>();

    public virtual ICollection<TmpAngelfishClaudeChosenPart> TmpAngelfishClaudeChosenPartGuessedPartnoNavigations { get; set; } = new List<TmpAngelfishClaudeChosenPart>();

    public virtual ICollection<TmpArMotorServiceFromEj> TmpArMotorServiceFromEjs { get; set; } = new List<TmpArMotorServiceFromEj>();

    public virtual ICollection<TmpCableTestPathsAutoSearchResult> TmpCableTestPathsAutoSearchResults { get; set; } = new List<TmpCableTestPathsAutoSearchResult>();

    public virtual ICollection<TmpLdsystemsAutoSearchResult> TmpLdsystemsAutoSearchResults { get; set; } = new List<TmpLdsystemsAutoSearchResult>();

    public virtual ICollection<TmpLdsystemsClaudeChosenPart> TmpLdsystemsClaudeChosenParts { get; set; } = new List<TmpLdsystemsClaudeChosenPart>();

    public virtual ICollection<UsedGearSalesPartCollection> UsedGearSalesPartCollections { get; set; } = new List<UsedGearSalesPartCollection>();

    public virtual ICollection<WarehouseCycleCount> WarehouseCycleCounts { get; set; } = new List<WarehouseCycleCount>();

    public virtual ICollection<ProjectChecklistItem> IdItems { get; set; } = new List<ProjectChecklistItem>();
}
