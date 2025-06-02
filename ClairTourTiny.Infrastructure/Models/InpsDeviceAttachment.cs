using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpsDeviceAttachment
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string AttachmentType { get; set; } = null!;

    public string AttachmentPath { get; set; } = null!;
}
