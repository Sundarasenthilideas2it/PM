using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Em2Employee
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Ssn { get; set; } = null!;

    public string Empno { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Midname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateTime Hiredate { get; set; }

    public string Locationcd { get; set; } = null!;

    public string Groupno { get; set; } = null!;

    public string Gradecd { get; set; } = null!;

    public string Empstatus { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public DateTime Termdate { get; set; }

    public string UserName { get; set; } = null!;

    public string Cellphone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Passportno { get; set; } = null!;

    public string Issuecountry { get; set; } = null!;

    public DateTime Issuedate { get; set; }

    public DateTime ExpireDate { get; set; }

    public string Issueplace { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string Birthplace { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public string Alienno { get; set; } = null!;

    public DateTime AlienExpiredate { get; set; }

    public string Airport { get; set; } = null!;

    public string Smoker { get; set; } = null!;

    public string Dietary { get; set; } = null!;

    public string EmergencyName { get; set; } = null!;

    public string EmergencyPhone1 { get; set; } = null!;

    public string EmergencyPhone2 { get; set; } = null!;

    public string EmergencyRelation { get; set; } = null!;

    public string Nickname { get; set; } = null!;

    public string Spouse { get; set; } = null!;

    public string Travelrestrictions { get; set; } = null!;

    public string DriversLicense { get; set; } = null!;

    public DateTime DriversLicenseExpire { get; set; }

    public string DriversLicenseState { get; set; } = null!;

    public string? Empcompanyno { get; set; }

    public string? EmpHeadShotFilePath { get; set; }

    public string? EmpPassportScanFilePath { get; set; }

    public string? EmpDriversLicenseScan { get; set; }

    public string? Notes { get; set; }

    public string? Countrycode { get; set; }

    public string? Filestat { get; set; }

    public string? OfficeDirectPhone { get; set; }

    public string? OtherEcontact { get; set; }

    public DateTime? LastPayRaiseDate { get; set; }

    public string? JobTitle { get; set; }

    public int? EmployeeDepartment { get; set; }

    public string? CovidvaccineStatusCode { get; set; }

    public int? ISolvedId { get; set; }

    public string? SecondPassportNo { get; set; }

    public string? SecondPassportIssueCountry { get; set; }

    public DateTime? SecondPassportIssueDate { get; set; }

    public DateTime? SecondPassportExpirationDate { get; set; }

    public string? SecondEmpPassportScanFilePath { get; set; }

    public string? SecondEmpPassportIssuePlace { get; set; }
}
