using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AttachmentTypeDatabaseRole
{
    public string AttachmentType { get; set; } = null!;

    public string DatabaseRole { get; set; } = null!;

    public virtual AttachmentType AttachmentTypeNavigation { get; set; } = null!;
}
