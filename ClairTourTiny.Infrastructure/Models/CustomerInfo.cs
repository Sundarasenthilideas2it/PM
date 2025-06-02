using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerInfo
{
    public string CustomerId { get; set; } = null!;

    public string? Name { get; set; }

    public DateOnly? CreationDate { get; set; }

    public string? AssociationNo { get; set; }

    public string? Party { get; set; }

    public string? DefaultDomain { get; set; }

    public string? DefaultLanguage { get; set; }

    public string? Country { get; set; }

    public string? PartyType { get; set; }

    public string? CorporateForm { get; set; }

    public string? IdentifierReference { get; set; }

    public string? IdentifierRefValidation { get; set; }

    public int? PictureId { get; set; }

    public string? OneTime { get; set; }

    public string? CustomerCategory { get; set; }

    public string? B2bCustomer { get; set; }

    public string? CustomerTaxUsageType { get; set; }

    public string? BusinessClassification { get; set; }

    public DateOnly? DateOfRegistration { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }
}
