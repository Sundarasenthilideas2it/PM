using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EgnyteShareRequest
{
    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public Guid FileStorageGuid { get; set; }

    public string FileStoragePath { get; set; } = null!;

    public bool IsExecuted { get; set; }

    public DateTime CreationTimeUtc { get; set; }

    public string AttachmentCategory { get; set; } = null!;

    public string? Note { get; set; }

    public string Server { get; set; } = null!;

    public string SharedBy { get; set; } = null!;

    public bool IsAddFolderMember { get; set; }

    public bool IsRemoveFolderMember { get; set; }

    public DateTime LastUpdateTimeUtc { get; set; }

    public virtual FileStoragePath FileStorage { get; set; } = null!;
}
