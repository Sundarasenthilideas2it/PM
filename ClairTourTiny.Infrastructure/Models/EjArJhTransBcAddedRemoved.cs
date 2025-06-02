using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjArJhTransBcAddedRemoved
{
    public int IdStockItem { get; set; }

    public int IdStockType { get; set; }

    public string EjPartno { get; set; } = null!;

    public string? FPartno { get; set; }

    public string EjPartdesc { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? Serialnumber { get; set; }

    public int? IIdOwner { get; set; }

    public string? IOwner { get; set; }

    public decimal? Price { get; set; }

    public int? Idstock { get; set; }

    public string T2jWh { get; set; } = null!;

    public DateTime? BoughtDate { get; set; }

    public DateTime? LastService { get; set; }

    public int Back { get; set; }

    public string Idjob { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public int? IdJobService { get; set; }

    public string Entityno { get; set; } = null!;

    public int? CustomNumber { get; set; }

    public string EjEntityDesc { get; set; } = null!;

    public int? IdStockType2InventoryTypeIn { get; set; }

    public int? InType { get; set; }

    public string? InCaption { get; set; }

    public DateTime? InWarranty { get; set; }

    public int? IdStockType2InventoryTypeOut { get; set; }

    public int? OutType { get; set; }

    public string? OutCaption { get; set; }

    public DateTime? OutWarranty { get; set; }

    public DateTime? OutCreationDate { get; set; }

    public int? IdUserCreated { get; set; }

    public string? LoginnameC { get; set; }

    public DateTime? CreationTime { get; set; }

    public int? IdUserUpdated { get; set; }

    public string? LoginnameU { get; set; }

    public DateTime? UpdateTime { get; set; }
}
