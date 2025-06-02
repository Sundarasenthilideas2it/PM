using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Peemployee
{
    public string Ssn { get; set; } = null!;

    public string Empno { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Midname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateTime Hiredate { get; set; }

    public string Filestat { get; set; } = null!;

    public int Exemptions { get; set; }

    public string Autodeposit { get; set; } = null!;

    public string Bankid { get; set; } = null!;

    public string Acctid { get; set; } = null!;

    public string Locationcd { get; set; } = null!;

    public string Groupno { get; set; } = null!;

    public string Gradecd { get; set; } = null!;

    public string Empstatus { get; set; } = null!;

    public double Billgoal { get; set; }

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Shiftno { get; set; } = null!;

    public string Sunoff { get; set; } = null!;

    public string Monoff { get; set; } = null!;

    public string Tueoff { get; set; } = null!;

    public string Wedoff { get; set; } = null!;

    public string Thuroff { get; set; } = null!;

    public string Frioff { get; set; } = null!;

    public string Satoff { get; set; } = null!;

    public decimal Ytdgross { get; set; }

    public decimal Prev1ytdgross { get; set; }

    public decimal Prev2ytdgross { get; set; }

    public decimal Prev3ytdgross { get; set; }

    public decimal Prev4ytdgross { get; set; }

    public decimal Prev5ytdgross { get; set; }

    public decimal Qtdgross { get; set; }

    public decimal Prev1qtdgross { get; set; }

    public decimal Prev2qtdgross { get; set; }

    public decimal Prev3qtdgross { get; set; }

    public decimal Prev4qtdgross { get; set; }

    public decimal Prev5qtdgross { get; set; }

    public decimal Ptdgross { get; set; }

    public decimal Prev1ptdgross { get; set; }

    public decimal Prev2ptdgross { get; set; }

    public decimal Prev3ptdgross { get; set; }

    public decimal Prev4ptdgross { get; set; }

    public decimal Prev5ptdgross { get; set; }

    public decimal Lastgross { get; set; }

    public decimal Prev1lastgross { get; set; }

    public decimal Prev2lastgross { get; set; }

    public decimal Prev3lastgross { get; set; }

    public decimal Prev4lastgross { get; set; }

    public decimal Prev5lastgross { get; set; }

    public decimal Ytdnet { get; set; }

    public decimal Prev1ytdnet { get; set; }

    public decimal Prev2ytdnet { get; set; }

    public decimal Prev3ytdnet { get; set; }

    public decimal Prev4ytdnet { get; set; }

    public decimal Prev5ytdnet { get; set; }

    public decimal Qtdnet { get; set; }

    public decimal Prev1qtdnet { get; set; }

    public decimal Prev2qtdnet { get; set; }

    public decimal Prev3qtdnet { get; set; }

    public decimal Prev4qtdnet { get; set; }

    public decimal Prev5qtdnet { get; set; }

    public decimal Ptdnet { get; set; }

    public decimal Prev1ptdnet { get; set; }

    public decimal Prev2ptdnet { get; set; }

    public decimal Prev3ptdnet { get; set; }

    public decimal Prev4ptdnet { get; set; }

    public decimal Prev5ptdnet { get; set; }

    public decimal Lastnet { get; set; }

    public decimal Prev1lastnet { get; set; }

    public decimal Prev2lastnet { get; set; }

    public decimal Prev3lastnet { get; set; }

    public decimal Prev4lastnet { get; set; }

    public decimal Prev5lastnet { get; set; }

    public string Termcode { get; set; } = null!;

    public DateTime Termdate { get; set; }

    public string UserName { get; set; } = null!;

    public string? Empcompanyno { get; set; }

    public string? EmpHeadShotFilePath { get; set; }

    public string? EmpPassportScanFilePath { get; set; }

    public string? EmpDriversLicenseScan { get; set; }

    public string? Notes { get; set; }

    public string? Countrycode { get; set; }

    public string? SignatureFilename { get; set; }

    public bool ExcludeFromReporting { get; set; }

    public string? OfficeDirectPhone { get; set; }

    public DateTime? LastPayRaiseDate { get; set; }

    public Guid Guid { get; set; }

    public string? JobTitle { get; set; }

    public int? EmployeeDepartment { get; set; }

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

    public string? CovidvaccineStatusCode { get; set; }

    public int? ISolvedId { get; set; }

    public string? SecondPassportNo { get; set; }

    public string? SecondPassportIssueCountry { get; set; }

    public DateTime SecondPassportIssueDate { get; set; }

    public DateTime SecondPassportExpirationDate { get; set; }

    public string? SecondEmpPassportScanFilePath { get; set; }

    public string? SecondEmpPassportIssuePlace { get; set; }

    public string? ManualFullName { get; set; }

    public string? Fullname { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual Country? CountrycodeNavigation { get; set; }

    public virtual Peempcompany? EmpcompanynoNavigation { get; set; }

    public virtual EmployeeDepartment? EmployeeDepartmentNavigation { get; set; }

    public virtual ICollection<EmployeeJobTypeQualificationsHistory> EmployeeJobTypeQualificationsHistories { get; set; } = new List<EmployeeJobTypeQualificationsHistory>();

    public virtual ICollection<EmployeePayRate> EmployeePayRates { get; set; } = new List<EmployeePayRate>();

    public virtual ICollection<EmployeeProperty> EmployeeProperties { get; set; } = new List<EmployeeProperty>();

    public virtual EmployeeStatus EmpstatusNavigation { get; set; } = null!;

    public virtual ICollection<Glentity> GlentityAcctExecEmpnoNavigations { get; set; } = new List<Glentity>();

    public virtual ICollection<Glentity> GlentityCrewOpsEmpnoNavigations { get; set; } = new List<Glentity>();

    public virtual ICollection<Glentity> GlentityEngrEmpnoNavigations { get; set; } = new List<Glentity>();

    public virtual ICollection<Glentity> GlentityOpsmgrNavigations { get; set; } = new List<Glentity>();

    public virtual ICollection<Glentity> GlentityRespempnoNavigations { get; set; } = new List<Glentity>();

    public virtual ICollection<Glentity> GlentityRfplempnoNavigations { get; set; } = new List<Glentity>();

    public virtual ICollection<Glentity> GlentitySecondaryOpsEmpnoNavigations { get; set; } = new List<Glentity>();

    public virtual Pejob GradecdNavigation { get; set; } = null!;

    public virtual Pedivision GroupnoNavigation { get; set; } = null!;

    public virtual Warehouse LocationcdNavigation { get; set; } = null!;

    public virtual ICollection<PeEmployeeDuplicateMap> PeEmployeeDuplicateMapNewEmpnoNavigations { get; set; } = new List<PeEmployeeDuplicateMap>();

    public virtual PeEmployeeDuplicateMap? PeEmployeeDuplicateMapOldEmpnoNavigation { get; set; }

    public virtual ICollection<PeEmployeeTrainingTopic> PeEmployeeTrainingTopics { get; set; } = new List<PeEmployeeTrainingTopic>();

    public virtual ICollection<PeEmployeeTraining> PeEmployeeTrainings { get; set; } = new List<PeEmployeeTraining>();

    public virtual ICollection<PeTrainingClassStudent> PeTrainingClassStudents { get; set; } = new List<PeTrainingClassStudent>();

    public virtual ICollection<PeempReview> PeempReviews { get; set; } = new List<PeempReview>();

    public virtual ICollection<Pjempassign> Pjempassigns { get; set; } = new List<Pjempassign>();

    public virtual ICollection<PurchaseOrderLineItems> PurchaseOrderLineItems { get; set; } = new List<PurchaseOrderLineItems>();

    public virtual ICollection<Pejob> Jobtypes { get; set; } = new List<Pejob>();

    public virtual ICollection<Language> Languagecds { get; set; } = new List<Language>();
}
