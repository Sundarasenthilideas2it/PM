using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ActiveDirectoryPhone
{
    public string ActiveDirectoryId { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual ActiveDirectoryContact ActiveDirectory { get; set; } = null!;
}
