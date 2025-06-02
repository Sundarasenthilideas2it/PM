using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerInfoTab
{
    public string CustomerId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string? AssociationNo { get; set; }

    public string Party { get; set; } = null!;

    public string DefaultDomain { get; set; } = null!;

    public string? DefaultLanguage { get; set; }

    public string? Country { get; set; }

    public string PartyType { get; set; } = null!;

    public string? CorporateForm { get; set; }

    public string? IdentifierReference { get; set; }

    public string IdentifierRefValidation { get; set; } = null!;

    public double? PictureId { get; set; }

    public string OneTime { get; set; } = null!;

    public string CustomerCategory { get; set; } = null!;

    public string B2bCustomer { get; set; } = null!;

    public string? CustomerTaxUsageType { get; set; }

    public string? BusinessClassification { get; set; }

    public DateTime? DateOfRegistration { get; set; }

    public DateTime Rowversion { get; set; }

    public string Rowkey { get; set; } = null!;
}
