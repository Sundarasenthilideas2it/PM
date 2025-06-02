using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairActivitiesBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public int IdActivity { get; set; }

    public int IdTicket { get; set; }

    public DateTime EntryDate { get; set; }

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
}
