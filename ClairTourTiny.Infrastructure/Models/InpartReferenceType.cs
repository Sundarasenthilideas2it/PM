using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartReferenceType
{
    public short IdReferenceType { get; set; }

    public string ReferenceType { get; set; } = null!;

    public short? SortOrder { get; set; }

    public virtual ICollection<InpartReference> InpartReferences { get; set; } = new List<InpartReference>();
}
