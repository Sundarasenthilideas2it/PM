using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpsAddInventory
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Partno { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Row { get; set; } = null!;

    public int Onhand { get; set; }

    public string Acctno { get; set; } = null!;

    public string? Ref4 { get; set; }

    public string? Ref5 { get; set; }

    public bool? RemoveNonCoded { get; set; }

    public string? Ponumber { get; set; }

    public bool ShouldLinkChildParts { get; set; }

    public string? Ipaddress { get; set; }

    public string? MacAddress { get; set; }

    public DateTime? PodateEntered { get; set; }

    public string? Posite { get; set; }

    public string? PointernalCustomer { get; set; }

    public string? PointernalDestinationId { get; set; }

    public string? PointernalDestination { get; set; }

    public int? PolineNo { get; set; }

    public int? PoreleaseNo { get; set; }

    public string? PolocationNo { get; set; }

    public string? PolotBatchNo { get; set; }

    public string? PonoteText { get; set; }

    public bool? PoisSerialized { get; set; }

    public bool? IsDisassembly { get; set; }

    public string? ParentPartNo { get; set; }

    public string? PopartNo { get; set; }

    public int? PoqtyArrived { get; set; }
}
