using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UserRole
{
    public string PermissionName { get; set; } = null!;

    public string Username { get; set; } = null!;
}
