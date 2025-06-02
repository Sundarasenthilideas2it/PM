using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PaylocityContact
{
    public string PaylocityId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? Department { get; set; }

    public string? Organization { get; set; }

    public string? Location { get; set; }

    public string? JobCode { get; set; }

    public DateTimeOffset DateCreated { get; set; }

    public DateTimeOffset LastModified { get; set; }

    public string Status { get; set; } = null!;

    public string? PictureFilePath { get; set; }

    public virtual ICollection<PaylocityAddress> PaylocityAddresses { get; set; } = new List<PaylocityAddress>();

    public virtual ICollection<PaylocityEmail> PaylocityEmails { get; set; } = new List<PaylocityEmail>();

    public virtual ICollection<PaylocityPhone> PaylocityPhones { get; set; } = new List<PaylocityPhone>();
}
