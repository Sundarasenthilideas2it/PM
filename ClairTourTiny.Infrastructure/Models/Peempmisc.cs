using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Peempmisc
{
    public string Empno { get; set; } = null!;

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

    public string? OtherEcontact { get; set; }
}
