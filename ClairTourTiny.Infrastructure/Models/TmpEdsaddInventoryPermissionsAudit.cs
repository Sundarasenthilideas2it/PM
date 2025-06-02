using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsaddInventoryPermissionsAudit
{
    public string? CompanyDesc { get; set; }

    public string? UserName { get; set; }

    public string? Empname { get; set; }

    public string? OwnerEntity { get; set; }

    public string? WarehouseEntity { get; set; }

    public string? Email { get; set; }

    public string? PermissionEdit { get; set; }
}
