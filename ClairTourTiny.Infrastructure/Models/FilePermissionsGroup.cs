using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FilePermissionsGroup
{
    public string GroupName { get; set; } = null!;

    public string? GroupPath { get; set; }

    public string? EgnytePermissionGroup { get; set; }

    public virtual ICollection<GroupPermission> GroupPermissions { get; set; } = new List<GroupPermission>();
}
