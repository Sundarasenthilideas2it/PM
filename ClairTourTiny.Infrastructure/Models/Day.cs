using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Day
{
    public DateTime Date { get; set; }

    public virtual ICollection<EmployeeJobTypeQualificationsHistory> EmployeeJobTypeQualificationsHistoryEndDateNavigations { get; set; } = new List<EmployeeJobTypeQualificationsHistory>();

    public virtual ICollection<EmployeeJobTypeQualificationsHistory> EmployeeJobTypeQualificationsHistoryStartDateNavigations { get; set; } = new List<EmployeeJobTypeQualificationsHistory>();

    public virtual ICollection<PartLocationHistory> PartLocationHistoryEndDateNavigations { get; set; } = new List<PartLocationHistory>();

    public virtual ICollection<PartLocationHistory> PartLocationHistoryStartDateNavigations { get; set; } = new List<PartLocationHistory>();

    public virtual ICollection<PePayPeriod> PePayPeriodEndDateNavigations { get; set; } = new List<PePayPeriod>();

    public virtual PePayPeriod? PePayPeriodStartDateNavigation { get; set; }

    public virtual ICollection<TmpPePayPeriodsWeekly> TmpPePayPeriodsWeeklyEndDateNavigations { get; set; } = new List<TmpPePayPeriodsWeekly>();

    public virtual TmpPePayPeriodsWeekly? TmpPePayPeriodsWeeklyStartDateNavigation { get; set; }
}
