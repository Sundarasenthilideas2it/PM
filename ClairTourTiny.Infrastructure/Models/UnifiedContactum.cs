using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UnifiedContactum
{
    public int? UnifiedContactId { get; set; }

    public string? PaylocityId { get; set; }

    public string? PodioId { get; set; }

    public string? EmployeeId { get; set; }

    public string? VendorId { get; set; }

    public string? CustomerId { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? Organization { get; set; }

    public string? Department { get; set; }

    public string? Location { get; set; }

    public DateTimeOffset? DateCreated { get; set; }

    public DateTimeOffset? LastModified { get; set; }

    public string? Status { get; set; }

    public string? PictureFilePath { get; set; }

    public bool? IsEmployee { get; set; }

    public bool? IsRoadStaff { get; set; }

    public bool? IsSubcontract { get; set; }

    public bool? IsVendor { get; set; }

    public bool? IsCustomer { get; set; }

    public string? ActiveDirectoryId { get; set; }

    public int? ISolvedId { get; set; }
}
