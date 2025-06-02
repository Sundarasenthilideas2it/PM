using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EgnyteShareRequestsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public Guid FileStorageGuid { get; set; }

    public string FileStoragePath { get; set; } = null!;

    public bool IsExecuted { get; set; }

    public DateTime CreationTimeTimeUtc { get; set; }

    public string? AttachmentCategory { get; set; }

    public string? Note { get; set; }
}
