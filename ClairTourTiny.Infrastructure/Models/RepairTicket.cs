using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairTicket
{
    public int IdTicket { get; set; }

    public string? Partno { get; set; }

    public string? UniqueNo { get; set; }

    public string? MfgPartno { get; set; }

    public string? MfgModelNo { get; set; }

    public string? MfgUniqueNo { get; set; }

    public string? MfgSerialNo { get; set; }

    public string? LastProjectEntityno { get; set; }

    public virtual Glentity? LastProjectEntitynoNavigation { get; set; }

    public virtual ICollection<RepairActivity> RepairActivities { get; set; } = new List<RepairActivity>();
}
