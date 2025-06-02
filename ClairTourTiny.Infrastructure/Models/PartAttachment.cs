using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartAttachment
{
    public string Partno { get; set; } = null!;

    public string AttachmentType { get; set; } = null!;

    public string AttachmentPath { get; set; } = null!;

    public virtual AttachmentType AttachmentTypeNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
