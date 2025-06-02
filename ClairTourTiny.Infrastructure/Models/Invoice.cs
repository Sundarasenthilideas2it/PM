using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Invoice
{
    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public string InvoiceNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string InvoiceTag { get; set; } = null!;

    public int? ClairNewInvoiceId { get; set; }

    public string Notes { get; set; } = null!;

    public string BodyText { get; set; } = null!;

    public string FooterText { get; set; } = null!;

    public decimal Total { get; set; }

    public string Locationcd { get; set; } = null!;

    public string? Name { get; set; }

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string? Country { get; set; }

    public string? ShippingAddr1 { get; set; }

    public string? ShippingAddr2 { get; set; }

    public string? ShippingAddr3 { get; set; }

    public string? ShippingCity { get; set; }

    public string? ShippingState { get; set; }

    public string? ShippingZip { get; set; }

    public string? ShippingCountry { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Frghtmatrix { get; set; } = null!;

    public string BillToName { get; set; } = null!;

    public string BillToContact { get; set; } = null!;

    public string BillToAttention { get; set; } = null!;

    public string BillToPhone { get; set; } = null!;

    public string BillToExt { get; set; } = null!;

    public string BillToAddr1 { get; set; } = null!;

    public string BillToAddr2 { get; set; } = null!;

    public string BillToAddr3 { get; set; } = null!;

    public string BillToCity { get; set; } = null!;

    public string? BillToCounty { get; set; }

    public string BillToState { get; set; } = null!;

    public string BillToZip { get; set; } = null!;

    public string BillToCountry { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public int? BankAccountId { get; set; }

    public string? Paytermscd { get; set; }

    public string? BankAccountText { get; set; }

    public string Attention { get; set; } = null!;

    public string? Ponumber { get; set; }

    public string? Custno { get; set; }

    public string? Subno { get; set; }

    public int InvoiceSeqno { get; set; }

    public int? InvoiceSplitId { get; set; }

    public decimal? ChunksNotRoundedTarget { get; set; }

    public decimal? ChunksNotRoundedUntouchable { get; set; }

    public decimal? RoundedChunksSum { get; set; }

    public int LineItemOneGrainUnit { get; set; }

    public decimal? CentsToDistribute { get; set; }

    public decimal? GrainsToDistribute { get; set; }

    public int InvoiceChunkCount { get; set; }

    public int InvoiceChunkUntouchableCount { get; set; }

    public int? GrainsToDistributeToEachLineItem { get; set; }

    public int? RemainingGrainsToDistribute { get; set; }

    public int InvoiceOneGrainUnit { get; set; }

    public string? Accountno { get; set; }

    public int IdLanguage { get; set; }

    public DateTime CreatedDateUtc { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public string? OrderedBy { get; set; }

    public string? PayTermsNote { get; set; }

    public string? ProjectTag { get; set; }

    public string? BillToEmail { get; set; }

    public string? BillToEmail2 { get; set; }

    public bool ShouldPushToSyspro { get; set; }

    public DateTimeOffset? PushedToSyspro { get; set; }

    public DateTime? InvoiceDueDate { get; set; }

    public string? SysproCustomerOrderNumber { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTimeOffset? LastAttemptedPush { get; set; }

    public virtual BankAccount? BankAccount { get; set; }

    public virtual XlatLanguage IdLanguageNavigation { get; set; } = null!;

    public virtual ICollection<InvoicePiece> InvoicePieces { get; set; } = new List<InvoicePiece>();

    public virtual InvoiceSeries InvoiceSeries { get; set; } = null!;

    public virtual ICollection<InvoiceTax> InvoiceTaxes { get; set; } = new List<InvoiceTax>();

    public virtual Oepayterm? PaytermscdNavigation { get; set; }
}
