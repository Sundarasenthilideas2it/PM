using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsnonBarcodesTransfer
{
    public int? Qty { get; set; }

    public string? Partno { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string FromBatchNo { get; set; } = null!;

    public string? ToBatchNo { get; set; }

    public string FromDept { get; set; } = null!;

    public string ToDept { get; set; } = null!;

    public string FromArea { get; set; } = null!;

    public string ToArea { get; set; } = null!;

    public string? FromBld { get; set; }

    public string? ToBld { get; set; }

    public string Row { get; set; } = null!;

    public int Pieces { get; set; }

    public string ParentuniqueNo { get; set; } = null!;

    public long? Conlineserialiid { get; set; }

    public long? Contractiid { get; set; }

    public long? Conlineiid { get; set; }

    public long? Serialiid { get; set; }

    public int? Lineno { get; set; }

    public short? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public int? Comments { get; set; }

    public string? Departmentid { get; set; }

    public int? Action { get; set; }

    public long? Inviid { get; set; }

    public int? Orderedqty { get; set; }

    public int? Shippedqty { get; set; }

    public short? Linetype { get; set; }

    public int? Returnedqty { get; set; }

    public string? Serialnumber { get; set; }

    public short? Shippingstatus { get; set; }

    public int? Quickturnaroundfor { get; set; }

    public string? Containerid { get; set; }

    public string? Description { get; set; }

    public string? Sku { get; set; }

    public short? Secondarystatus { get; set; }

    public string? Loadingbayid { get; set; }

    public string? Keeporiginalitemdescription { get; set; }
}
