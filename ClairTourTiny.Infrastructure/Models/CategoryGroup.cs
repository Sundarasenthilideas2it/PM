using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CategoryGroup
{
    public int GroupId { get; set; }

    public int SubGroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
