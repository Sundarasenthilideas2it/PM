using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SupplierInfoGeneral
{
    public string SupplierId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly? CreationDate { get; set; }

    public string AssociationNo { get; set; } = null!;

    public string? Party { get; set; }

    public bool? DefaultDomain { get; set; }

    public string? DefaultLanguage { get; set; }

    public string? DefaultLanguageDb { get; set; }

    public string? Country { get; set; }

    public string? CountryDb { get; set; }

    public string? PartyType { get; set; }

    public string? PartyTypeDb { get; set; }

    public string? SuppliersOwnId { get; set; }

    public string? CorporateForm { get; set; }

    public string? IdentifierReference { get; set; }

    public string? IdentifierRefValidation { get; set; }

    public string? IdentifierRefValidationDb { get; set; }

    public int? PictureId { get; set; }

    public string? OneTime { get; set; }

    public string? OneTimeDb { get; set; }

    public string? SupplierCategory { get; set; }

    public string? SupplierCategoryDb { get; set; }

    public string? B2bSupplier { get; set; }

    public string? B2bSupplierDb { get; set; }

    public string? BusinessClassification { get; set; }

    public string? Objkey { get; set; }

    public string? Objtype { get; set; }

    public string? Objversion { get; set; }

    public string? Objid { get; set; }
}
