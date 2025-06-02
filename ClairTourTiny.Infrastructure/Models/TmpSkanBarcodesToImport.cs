using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanBarcodesToImport
{
    public string? Partno { get; set; }

    public string? SerialNo { get; set; }

    public string? UniqueNo { get; set; }

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Row { get; set; } = null!;

    public string Onhand { get; set; } = null!;

    public string Acctno { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public int RemoveNonCode { get; set; }

    public string? Ponumber { get; set; }

    public int ShouldLinkChildParts { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedByDate { get; set; }

    public string CreatedByUser { get; set; } = null!;

    public DateTime LastEditDate { get; set; }

    public string LastEditUser { get; set; } = null!;

    public string? ResourceName { get; set; }

    public string? RcNumber { get; set; }

    public string? RcCode { get; set; }

    public string? BarCodeId { get; set; }

    public long RcNumberSeq { get; set; }

    public short IsDeleted { get; set; }

    public short IsCatItem { get; set; }

    public short IsPubCatItem { get; set; }

    public DateTime? AvailableDate { get; set; }

    public DateTime? DiscontinueDate { get; set; }

    public short PresumedMissing { get; set; }

    public string? DebitAcctId { get; set; }

    public string? CreditAcctId { get; set; }

    public string? TimeAcctId { get; set; }

    public string? ColorCode { get; set; }

    public string? UserFieldOne { get; set; }

    public string? UserFieldTwo { get; set; }

    public string? UserFieldThree { get; set; }

    public string? UserFieldFour { get; set; }

    public string? UserFieldFive { get; set; }

    public string? UserFieldSix { get; set; }

    public string? UserFieldSeven { get; set; }

    public string? UserFieldEight { get; set; }

    public string? UserFieldNine { get; set; }

    public string? UserFieldTen { get; set; }

    public string? PhoneticTokens { get; set; }

    public string? LiteralTokens { get; set; }

    public string? ResourceShortName { get; set; }

    public short Discountable { get; set; }

    public float? MaxDiscount { get; set; }

    public string? NarrativeDescription { get; set; }

    public DateTime? DeletedByDate { get; set; }

    public string? DeletedByUserId { get; set; }

    public short LineMuteByDefault { get; set; }

    public string? DisplayString { get; set; }

    public string? ExternalNumber { get; set; }

    public short NoteMuteByDefault { get; set; }

    public string? BarCodeLabel { get; set; }

    public string? RfidTag { get; set; }

    public string? SerialNumberId { get; set; }

    public string? SerialNumber { get; set; }

    public string? Stencil { get; set; }

    public string? NoteText { get; set; }

    public short? Ooc { get; set; }

    public DateTime? DatePurchased { get; set; }

    public float? CurrentValue { get; set; }

    public float? ReplacementCost { get; set; }

    public short? IsRemoved { get; set; }

    public string? ModelNumber { get; set; }

    public short? SnIsDeleted { get; set; }

    public short? IsPermanentMember { get; set; }

    public short? IsSold { get; set; }

    public float? SoldCost { get; set; }

    public DateTime? SoldDate { get; set; }

    public string? ItemId { get; set; }

    public string? PurchaseCurrencyId { get; set; }

    public string? ContainerId { get; set; }

    public string? StorageLocationId { get; set; }

    public string? HomebaseLocationId { get; set; }

    public string? PurchaseOrderId { get; set; }

    public string? LastScanId { get; set; }

    public string? SubrentalVendorId { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? SoldRecordId { get; set; }

    public short? IsStorageContainerReady { get; set; }

    public short? IsDirtyStorageContainer { get; set; }

    public short? IsDecommissioned { get; set; }

    public DateTime? DecommissionedDate { get; set; }

    public string? DecommissionedByUser { get; set; }

    public float? PurchaseCost { get; set; }

    public decimal? DepreciationPeriod { get; set; }

    public decimal? SalvageValue { get; set; }
}
