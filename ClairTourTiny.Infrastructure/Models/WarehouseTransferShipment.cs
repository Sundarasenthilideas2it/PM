using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WarehouseTransferShipment
{
    public string Entityno { get; set; } = null!;

    public string SourceWh { get; set; } = null!;

    public string? DestinationWh { get; set; }

    public DateTime ShipDate { get; set; }

    public string ServiceTypeDisplayName { get; set; } = null!;

    public string CompanyDesc { get; set; } = null!;

    public string? RecipientName { get; set; }

    public string? DestinationName { get; set; }

    public int ExpenseTypeDetailCode { get; set; }

    public string? EntitynoRef { get; set; }

    public string Entitydesc { get; set; } = null!;

    public string? SenderUsername { get; set; }

    public string? SpecialAttention { get; set; }
}
