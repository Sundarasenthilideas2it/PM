using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AttachmentTypeContactCategory
{
    public string AttachmentType { get; set; } = null!;

    public int IdContactCategory { get; set; }

    public bool CanEdit { get; set; }

    public virtual AttachmentType AttachmentTypeNavigation { get; set; } = null!;

    public virtual ContactCategory IdContactCategoryNavigation { get; set; } = null!;
}
