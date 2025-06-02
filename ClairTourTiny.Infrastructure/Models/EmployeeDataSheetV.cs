using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeDataSheetV
{
    public string Empno { get; set; } = null!;

    public string Empname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Cellphone { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string? Countrycode { get; set; }

    public string Passportno { get; set; } = null!;

    public string Issuecountry { get; set; } = null!;

    public DateTime Issuedate { get; set; }

    public string Nationality { get; set; } = null!;

    public string Issueplace { get; set; } = null!;

    public DateTime ExpireDate { get; set; }

    public DateTime Birthdate { get; set; }

    public string Birthplace { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Airport { get; set; } = null!;

    public string Dietary { get; set; } = null!;

    public string Spouse { get; set; } = null!;

    public string? EmpHeadShotFilePath { get; set; }

    public string? EmpPassportScanFilePath { get; set; }
}
