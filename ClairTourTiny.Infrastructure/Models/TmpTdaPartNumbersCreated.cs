using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaPartNumbersCreated
{
    public short SessionId { get; set; }

    public DateTime? Updatetime { get; set; }

    public int IsInsert { get; set; }

    public int IsUpdate { get; set; }

    public int IsDelete { get; set; }

    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string Package { get; set; } = null!;

    public string Acctno { get; set; } = null!;

    public string? PartdescSales { get; set; }

    public string MakePurchase { get; set; } = null!;

    public string Parent { get; set; } = null!;

    public double? Weight { get; set; }

    public string Origin { get; set; } = null!;

    public decimal BidValueUsd { get; set; }

    public double? RentalValueUsd { get; set; }

    public string? Commodity { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public int Locationcd { get; set; }

    public string? MaterialDesc { get; set; }

    public string? Sku { get; set; }

    public int? NewIdStockTypeCategory { get; set; }

    public int IdStockType { get; set; }

    public int? IdStockTypeExtension { get; set; }

    public string Number { get; set; } = null!;
}
