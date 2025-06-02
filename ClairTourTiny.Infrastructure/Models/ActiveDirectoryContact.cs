using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ActiveDirectoryContact
{
    public string ActiveDirectoryId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTimeOffset DateCreated { get; set; }

    public DateTimeOffset LastModified { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<ActiveDirectoryAddress> ActiveDirectoryAddresses { get; set; } = new List<ActiveDirectoryAddress>();

    public virtual ICollection<ActiveDirectoryEmail> ActiveDirectoryEmails { get; set; } = new List<ActiveDirectoryEmail>();

    public virtual ICollection<ActiveDirectoryPhone> ActiveDirectoryPhones { get; set; } = new List<ActiveDirectoryPhone>();

    public virtual Status StatusNavigation { get; set; } = null!;
}
