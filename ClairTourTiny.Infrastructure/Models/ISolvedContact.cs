using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ISolvedContact
{
    public int ISolvedId { get; set; }

    public string Name { get; set; } = null!;

    public string? Title { get; set; }

    public string? Department { get; set; }

    public string? Organization { get; set; }

    public string? Location { get; set; }

    public string? JobCode { get; set; }

    public string Status { get; set; } = null!;

    public string? TimeclockId { get; set; }

    public string? PictureFilePath { get; set; }

    public DateTimeOffset DateCreated { get; set; }

    public DateTimeOffset LastModified { get; set; }

    public string? ClientId { get; set; }

    public string? LegalCode { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? PayGroup { get; set; }

    public int? SupervisorIsolvedId { get; set; }

    public virtual ICollection<ISolvedAddress> ISolvedAddresses { get; set; } = new List<ISolvedAddress>();

    public virtual ICollection<ISolvedEmail> ISolvedEmails { get; set; } = new List<ISolvedEmail>();

    public virtual ICollection<ISolvedPhone> ISolvedPhones { get; set; } = new List<ISolvedPhone>();

    public virtual Status StatusNavigation { get; set; } = null!;
}
