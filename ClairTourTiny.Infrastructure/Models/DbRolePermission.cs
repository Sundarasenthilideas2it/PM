using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DbRolePermission
{
    public string Role { get; set; } = null!;

    public string PermissionName { get; set; } = null!;

    public virtual PermissionGroup PermissionNameNavigation { get; set; } = null!;
}
