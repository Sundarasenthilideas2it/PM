using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ContactCategory
{
    public int IdContactCategory { get; set; }

    public string ContactCategory1 { get; set; } = null!;

    public int SortOrder { get; set; }

    public bool? IsProjectClientContact { get; set; }

    public virtual ICollection<AttachmentTypeContactCategory> AttachmentTypeContactCategories { get; set; } = new List<AttachmentTypeContactCategory>();

    public virtual ICollection<Povendor> Vendnos { get; set; } = new List<Povendor>();
}
