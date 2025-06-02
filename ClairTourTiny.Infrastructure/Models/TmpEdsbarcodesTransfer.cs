using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsbarcodesTransfer
{
    public string? Entityno { get; set; }

    public int? Itemstatus { get; set; }

    public string? Assetstatus { get; set; }

    public string? OriginalBarcode { get; set; }

    public string? BarcodeToImport { get; set; }

    public string? UniqueNo { get; set; }

    public string? Dept { get; set; }

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
