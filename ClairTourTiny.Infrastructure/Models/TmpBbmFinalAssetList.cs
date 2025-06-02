using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBbmFinalAssetList
{
    public string? Nummer { get; set; }

    public string? Bezeichnung { get; set; }

    public string? Mutterwarengruppe { get; set; }

    public string? Warengruppe { get; set; }

    public double? Inventar { get; set; }

    public double? Mietinventar { get; set; }

    public decimal? Einkaufspreis { get; set; }

    public decimal? GesamtEk { get; set; }

    public string? BarcodeInfo { get; set; }

    public string? Lagerplatz { get; set; }

    public string? BezeichnungEnglish { get; set; }
}
