using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SupplierInfo
{
    public string SupplierId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string? AssociationNo { get; set; }

    public string Party { get; set; } = null!;

    public string? DefaultLanguage { get; set; }

    public string? Country { get; set; }

    public string PartyType { get; set; } = null!;

    public string? SuppliersOwnId { get; set; }

    public string? CorporateForm { get; set; }

    public string? IdentifierReference { get; set; }

    public int? PictureId { get; set; }

    public string OneTime { get; set; } = null!;

    public string SupplierCategory { get; set; } = null!;

    public string B2bSupplier { get; set; } = null!;

    public string? BusinessClassification { get; set; }

    public string DefaultDomain { get; set; } = null!;

    public string IdentifierRefValidation { get; set; } = null!;

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }

    public string? Rowtype { get; set; }
}
