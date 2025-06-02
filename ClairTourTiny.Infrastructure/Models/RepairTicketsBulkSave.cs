using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairTicketsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public int IdTicket { get; set; }

    public string? Partno { get; set; }

    public string? UniqueNo { get; set; }

    public string? MfgPartno { get; set; }

    public string? MfgModelNo { get; set; }

    public string? MfgUniqueNo { get; set; }

    public string? MfgSerialNo { get; set; }

    public string? LastProjectEntityno { get; set; }

    public decimal? LaborTime { get; set; }
}
