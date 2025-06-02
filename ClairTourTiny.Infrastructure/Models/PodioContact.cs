using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PodioContact
{
    public string PodioId { get; set; } = null!;

    public int? OldProfileId { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? Organization { get; set; }

    public DateTimeOffset DateCreated { get; set; }

    public DateTimeOffset LastModified { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<PodioAddress> PodioAddresses { get; set; } = new List<PodioAddress>();

    public virtual ICollection<PodioEmail> PodioEmails { get; set; } = new List<PodioEmail>();

    public virtual ICollection<PodioPhone> PodioPhones { get; set; } = new List<PodioPhone>();

    public virtual Status StatusNavigation { get; set; } = null!;
}
