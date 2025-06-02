using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pejob
{
    public string Jobtype { get; set; } = null!;

    public string Jobdesc { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public double Beginamt { get; set; }

    public double Endamt { get; set; }

    public double? Avgamt { get; set; }

    public double Hours { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public bool IsQualification { get; set; }

    public string? AbraHourlyPayCodePrefix { get; set; }

    public string? AbraHourlyPayCode { get; set; }

    public double? AbraDummyHours { get; set; }

    public double OvertimeHours { get; set; }

    public bool IsEngineerInCharge { get; set; }

    public bool IsGigMe { get; set; }

    public bool IsPaid { get; set; }

    public bool IsActive { get; set; }

    public bool IsVehicle { get; set; }

    public string ISolvedDepartment { get; set; } = null!;

    public virtual AbraHourlyPayCode? AbraHourlyPayCodeNavigation { get; set; }

    public virtual AbraHourlyPayCodePrefix? AbraHourlyPayCodePrefixNavigation { get; set; }

    public virtual ICollection<CrewBidValue> CrewBidValues { get; set; } = new List<CrewBidValue>();

    public virtual ICollection<EmployeeJobTypeQualificationsHistory> EmployeeJobTypeQualificationsHistories { get; set; } = new List<EmployeeJobTypeQualificationsHistory>();

    public virtual ICollection<EmployeePayRate> EmployeePayRates { get; set; } = new List<EmployeePayRate>();

    public virtual IntegrationProjectJobTypeCostBucket? IntegrationProjectJobTypeCostBucket { get; set; }

    public virtual ICollection<PeTrainingTopic> PeTrainingTopics { get; set; } = new List<PeTrainingTopic>();

    public virtual ICollection<Peemployee> Peemployees { get; set; } = new List<Peemployee>();

    public virtual ICollection<PejobTranslation> PejobTranslations { get; set; } = new List<PejobTranslation>();

    public virtual ICollection<Pjempassign> Pjempassigns { get; set; } = new List<Pjempassign>();

    public virtual ICollection<Pjjobbudget> Pjjobbudgets { get; set; } = new List<Pjjobbudget>();

    public virtual ICollection<Peemployee> Empnos { get; set; } = new List<Peemployee>();
}
