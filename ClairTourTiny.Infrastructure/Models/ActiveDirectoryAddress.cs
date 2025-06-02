using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ActiveDirectoryAddress
{
    public string ActiveDirectoryId { get; set; } = null!;

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? City { get; set; }

    public string? StateProvince { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual ActiveDirectoryContact ActiveDirectory { get; set; } = null!;
}
