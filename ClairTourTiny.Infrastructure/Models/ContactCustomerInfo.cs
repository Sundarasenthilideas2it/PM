using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ContactCustomerInfo
{
    public string CustomerId { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string PersonId { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? Title { get; set; }

    public string? CustomerAddress { get; set; }

    public string? ContactAddress { get; set; }

    public string? Role { get; set; }

    public string? RoleDb { get; set; }

    public string? Department { get; set; }

    public string? DepartmentDb { get; set; }

    public string? Manager { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Pager { get; set; }

    public string? Intercom { get; set; }

    public string? BlockedForCrmObjectsDb { get; set; }

    public string? ConnectAllCustAddrDb { get; set; }

    public string? Objid { get; set; }
}
