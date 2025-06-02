using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaResourceAllocation
{
    public int IdResourceAllocation { get; set; }

    public string? Empno { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string Locationcd { get; set; } = null!;

    public string Groupno { get; set; } = null!;

    public string? Gradecd { get; set; }

    public string Empstatus { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Email { get; set; }

    public string UserName { get; set; } = null!;

    public string? Notes { get; set; }

    public string? Country { get; set; }

    public string? PhoneCompany { get; set; }

    public string? JobTitle { get; set; }

    public int? EmployeeDepartment { get; set; }

    public string Cellphone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string? PassportNumber { get; set; }

    public string? Issuecountry { get; set; }

    public DateTime? PassportIssueDate { get; set; }

    public DateTime? PassportValidTo { get; set; }

    public string? PassportIssuePlace { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Birthplace { get; set; }

    public string EmergencyPhone2 { get; set; } = null!;

    public int? IdAddressResourceType { get; set; }

    public string? ResourceType { get; set; }

    public int? IdShortCutDefaultPicture { get; set; }

    public int? IdContactPrimary { get; set; }
}
