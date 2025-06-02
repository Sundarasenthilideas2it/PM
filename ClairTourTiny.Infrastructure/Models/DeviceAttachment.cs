using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DeviceAttachment
{
    public string UniqueNo { get; set; } = null!;

    public string AttachmentType { get; set; } = null!;

    public string AttachmentPath { get; set; } = null!;

    public virtual AttachmentType AttachmentTypeNavigation { get; set; } = null!;
}
