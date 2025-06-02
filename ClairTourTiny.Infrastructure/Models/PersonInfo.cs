using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PersonInfo
{
    public string PersonId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? Prefix { get; set; }

    public string? LastName { get; set; }

    public string? AlternativeName { get; set; }

    public string? BirthName { get; set; }

    public string? Alias { get; set; }

    public string? Initials { get; set; }

    public string? Title { get; set; }

    public string? JobTitle { get; set; }

    public DateTime CreationDate { get; set; }

    public string Party { get; set; } = null!;

    public int? PictureId { get; set; }

    public string Protected { get; set; } = null!;

    public string DefaultDomain { get; set; } = null!;

    public string? Country { get; set; }

    public string? DefaultLanguage { get; set; }

    public string PartyType { get; set; } = null!;

    public string? UserId { get; set; }

    public int? PictureThumbnailId { get; set; }

    public string? Inactive { get; set; }

    public string? ContactCustomers { get; set; }

    public string? ContactSuppliers { get; set; }

    public string CustomerContact { get; set; } = null!;

    public string BlockedForUse { get; set; } = null!;

    public bool? UpdateConBlockForCrmObjs { get; set; }

    public string SupplierContact { get; set; } = null!;

    public string BlockedForUseSupplier { get; set; } = null!;

    public string? WarrantyRep { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }

    public string? Rowstate { get; set; }
}
