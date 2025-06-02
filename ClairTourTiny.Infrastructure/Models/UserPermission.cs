using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UserPermission
{
    public string Username { get; set; } = null!;

    public int UId { get; set; }

    public string Role { get; set; } = null!;

    public int RoleId { get; set; }
}
