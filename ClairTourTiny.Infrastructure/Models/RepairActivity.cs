using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairActivity
{
    public int IdActivity { get; set; }

    public int IdTicket { get; set; }

    public DateTime? EntryDate { get; set; }

    public string EntryUserid { get; set; } = null!;

    public string ActivityType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Notes1 { get; set; }

    public string? Notes2 { get; set; }

    public int? LaborMinutes { get; set; }

    public DateTime? DeviceShippedDate { get; set; }

    public DateTime? DeviceReturnedDate { get; set; }

    public string? ExtRepairVendno { get; set; }

    public string? ExtRepairSiteNo { get; set; }

    public string? ExtRepairNotes { get; set; }

    public virtual RepairActivityType ActivityTypeNavigation { get; set; } = null!;

    public virtual Pjtfrusr EntryUser { get; set; } = null!;

    public virtual RepairTicket IdTicketNavigation { get; set; } = null!;

    public virtual ICollection<RepairActivitiesAttachment> RepairActivitiesAttachments { get; set; } = new List<RepairActivitiesAttachment>();
}
