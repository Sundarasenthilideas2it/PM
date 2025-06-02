using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class JdbWarehouseGear
{
    public string? Spid { get; set; }

    public string? Onhand { get; set; }

    public string? Partno { get; set; }

    public string? UniqueNo { get; set; }

    public string? SerialNo { get; set; }

    public string? FromBatchNo { get; set; }

    public string? ToBatchNo { get; set; }

    public string? FromDept { get; set; }

    public string? ToDept { get; set; }

    public string? FromArea { get; set; }

    public string? ToArea { get; set; }

    public string? FromBld { get; set; }

    public string? ToBld { get; set; }

    public string? Row { get; set; }

    public string? Pieces { get; set; }

    public string? ParentuniqueNo { get; set; }
}
