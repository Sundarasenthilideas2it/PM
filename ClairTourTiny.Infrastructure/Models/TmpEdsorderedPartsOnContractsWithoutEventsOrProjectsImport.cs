using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsorderedPartsOnContractsWithoutEventsOrProjectsImport
{
    public string? Entityno { get; set; }

    public int? Seqno { get; set; }

    public string Expcd { get; set; } = null!;

    public string? Partdesc { get; set; }

    public string? Partno { get; set; }

    public int LineNo { get; set; }

    public DateOnly? Trandate { get; set; }

    public DateOnly? Todate { get; set; }

    public decimal? EstUnitAmount { get; set; }

    public int? EstQty { get; set; }

    public decimal? EstAmount { get; set; }

    public decimal? EstRevAmount { get; set; }

    public decimal? EstRevTotal { get; set; }

    public string MfgNo { get; set; } = null!;

    public string MfgDesc { get; set; } = null!;

    public double? Markup { get; set; }

    public string NoteInternal { get; set; } = null!;

    public long? Conlineiid { get; set; }

    public long? Contractiid { get; set; }

    public string? Expanded { get; set; }

    public short? Type { get; set; }

    public long? Inviid { get; set; }

    public string? Sku { get; set; }

    public int? Lineno { get; set; }

    public short? Levelno { get; set; }

    public short? Attribute { get; set; }

    public string? Description { get; set; }

    public int? Quantity { get; set; }

    public short? Action { get; set; }

    public double? Amount { get; set; }

    public short? Status { get; set; }

    public double? Price { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public double? Discountamount { get; set; }

    public string? Isfreight { get; set; }

    public double? Sitecurrencyprice { get; set; }

    public double? Basecurrencyprice { get; set; }

    public double? Sitecurrencyamount { get; set; }

    public double? Basecurrencyamount { get; set; }

    public long? Mainparentconlineiid { get; set; }

    public long? Immediateparentconlineiid { get; set; }

    public double? Sitecurrencydiscountamount { get; set; }

    public double? Basecurrencydiscountamount { get; set; }

    public string? Isdescriptionmodified { get; set; }

    public DateTime? Pickupdate { get; set; }

    public DateTime? Returndate { get; set; }

    public DateTime? Chargestartdate { get; set; }

    public DateTime? Chargeenddate { get; set; }

    public DateTime? Prepdate { get; set; }

    public DateTime? Shipdate { get; set; }

    public DateTime? Showstartdate { get; set; }

    public DateTime? Showenddate { get; set; }

    public DateTime? Strikedate { get; set; }

    public DateTime? Loadindate { get; set; }

    public DateTime? Rehearsaldate { get; set; }
}
