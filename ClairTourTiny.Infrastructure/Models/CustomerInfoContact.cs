using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerInfoContact
{
    public string CustomerId { get; set; } = null!;

    public string PersonId { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public string? Role { get; set; }

    public string CustomerPrimary { get; set; } = null!;

    public string CustomerSecondary { get; set; } = null!;

    public string AddressPrimary { get; set; } = null!;

    public string AddressSecondary { get; set; } = null!;

    public DateTime Created { get; set; }

    public DateTime Changed { get; set; }

    public string? NoteText { get; set; }

    public string? CustomerAddress { get; set; }

    public string ConnectAllCustAddr { get; set; } = null!;

    public string? ContactAddress { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string ChangedBy { get; set; } = null!;

    public string BlockedForCrmObjects { get; set; } = null!;

    public string? PersonalInterest { get; set; }

    public string? CampaignInterest { get; set; }

    public string? DecisionPowerType { get; set; }

    public string? Department { get; set; }

    public string? Manager { get; set; }

    public string? ManagerGuid { get; set; }

    public string? ManagerCustAddress { get; set; }

    public string? MainRepresentativeId { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }
}
