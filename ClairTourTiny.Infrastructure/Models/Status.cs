using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Status
{
    public string StatusCode { get; set; } = null!;

    public string StatusDesc { get; set; } = null!;

    public byte? DisplayOrder { get; set; }

    public bool IsAvailable { get; set; }

    public virtual ICollection<ActiveDirectoryContact> ActiveDirectoryContacts { get; set; } = new List<ActiveDirectoryContact>();

    public virtual ICollection<ISolvedContact> ISolvedContacts { get; set; } = new List<ISolvedContact>();

    public virtual ICollection<PodioContact> PodioContacts { get; set; } = new List<PodioContact>();

    public virtual ICollection<UnifiedContact> UnifiedContacts { get; set; } = new List<UnifiedContact>();
}
