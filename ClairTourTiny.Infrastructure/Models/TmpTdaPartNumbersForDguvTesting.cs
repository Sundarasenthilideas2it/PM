using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaPartNumbersForDguvTesting
{
    public string? FinessePartNo { get; set; }

    public short SessionId { get; set; }

    public DateTime? Updatetime { get; set; }

    public int IsInsert { get; set; }

    public int IsUpdate { get; set; }

    public int IsDelete { get; set; }

    public string? Partno { get; set; }

    public string Partdesc { get; set; } = null!;

    public string Package { get; set; } = null!;

    public string Acctno { get; set; } = null!;

    public string PartdescSales { get; set; } = null!;

    public string MakePurchase { get; set; } = null!;

    public string Parent { get; set; } = null!;

    public decimal Weight { get; set; }

    public string Origin { get; set; } = null!;

    public decimal Bidvalue { get; set; }

    public decimal Rentalvalue { get; set; }

    public string Category { get; set; } = null!;

    public decimal Length { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public int Locationncd { get; set; }

    public string? MaterialDesc { get; set; }

    public string? Barcode { get; set; }

    public int? Secondarycategory { get; set; }

    public int IdStockType { get; set; }

    public string Number { get; set; } = null!;
}
