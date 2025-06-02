using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Category
{
    public Guid CategoryId { get; set; }

    public Guid? ParentCategoryId { get; set; }

    public int CategoryNameId { get; set; }

    public int GroupId { get; set; }

    public int SubGroupId { get; set; }

    public bool Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual CategoryGroup CategoryGroup { get; set; } = null!;

    public virtual CategoryName CategoryName { get; set; } = null!;

    public virtual ICollection<CategoryPart> CategoryParts { get; set; } = new List<CategoryPart>();
}
