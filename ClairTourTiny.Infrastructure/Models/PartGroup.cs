using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartGroup
{
    public string PartGroup1 { get; set; } = null!;

    public Guid FileStorageGuid { get; set; }

    public int? GroupId { get; set; }

    public bool IsGlobalPartGroup { get; set; }

    public virtual ICollection<PartGroupsPart> PartGroupsParts { get; set; } = new List<PartGroupsPart>();
}
