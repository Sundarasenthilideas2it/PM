using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GroupPermission
{
    public string GroupName { get; set; } = null!;

    public string AttachmentType { get; set; } = null!;

    public bool AllowFullControl { get; set; }

    public bool AllowModify { get; set; }

    public bool AllowReadExecute { get; set; }

    public bool AllowListFolderContents { get; set; }

    public bool AllowRead { get; set; }

    public bool AllowWrite { get; set; }

    public bool AllowSpecialPermissions { get; set; }

    public string? EgnytePermission { get; set; }

    public virtual AttachmentType AttachmentTypeNavigation { get; set; } = null!;

    public virtual FilePermissionsGroup GroupNameNavigation { get; set; } = null!;
}
