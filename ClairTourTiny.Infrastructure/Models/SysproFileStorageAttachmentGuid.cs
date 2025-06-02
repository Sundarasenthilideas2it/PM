using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproFileStorageAttachmentGuid
{
    public string AttachmentCategory { get; set; } = null!;

    public Guid Guid { get; set; }

    public string Keyfield { get; set; } = null!;
}
