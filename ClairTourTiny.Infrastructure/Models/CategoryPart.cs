using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CategoryPart
{
    public Guid CategoryPartId { get; set; }

    public Guid CategoryId { get; set; }

    public string PartNo { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual Category Category { get; set; } = null!;
}
