using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TempTransactionsReceievedFrom02012025
{
    public string? Po { get; set; }

    public string? PartNo { get; set; }

    public string? Description { get; set; }

    public decimal? FinesseQty { get; set; }

    public double? FinesseUnitPrice { get; set; }

    public double? FinesseTotalCost { get; set; }

    public DateTime? FinesseTransactionDate { get; set; }

    public string? FinesseWarehouse { get; set; }

    public string? Supplier { get; set; }

    public string? IfsCompany { get; set; }

    public double? IfsUnitPrice { get; set; }

    public int? IfsTotalCost { get; set; }

    public long? IfsQty { get; set; }

    public decimal? IfsQtyArrived { get; set; }

    public string? IfsWarehouse { get; set; }

    public string? IfsPoStatus { get; set; }

    public string? DifferenceDetails { get; set; }
}
