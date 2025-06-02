using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaAccountExecsCreated
{
    public int? IdUserArranger { get; set; }

    public int IdUser { get; set; }

    public string? Handle { get; set; }

    public string? DisplayName { get; set; }

    public int IdAddress { get; set; }

    public string? Empno { get; set; }

    public string? FirstName { get; set; }

    public string? Surname { get; set; }

    public string Locationcd { get; set; } = null!;

    public string Groupno { get; set; } = null!;

    public string Gradecd { get; set; } = null!;

    public string Empstatus { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Email { get; set; }

    public string UserName { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string? Isocode { get; set; }

    public string? PhoneCompany { get; set; }

    public int? JobTitle { get; set; }

    public int? EmployeeDepartment { get; set; }

    public string Cellphone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string PassportNo { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string Birthplace { get; set; } = null!;

    public string EmergencyPhone2 { get; set; } = null!;
}
