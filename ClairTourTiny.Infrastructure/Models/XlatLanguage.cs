using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class XlatLanguage
{
    public int IdLanguage { get; set; }

    public string Language { get; set; } = null!;

    public int? AltIdLanguage { get; set; }

    public bool? IncludeInQuoteReport { get; set; }

    public virtual ICollection<InpartTranslation> InpartTranslations { get; set; } = new List<InpartTranslation>();

    public virtual ICollection<InvoiceSeries> InvoiceSeries { get; set; } = new List<InvoiceSeries>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<IsoLanguageDef> IsoLanguageDefs { get; set; } = new List<IsoLanguageDef>();

    public virtual ICollection<OecustbillOld> OecustbillOlds { get; set; } = new List<OecustbillOld>();

    public virtual ICollection<PejobTranslation> PejobTranslations { get; set; } = new List<PejobTranslation>();

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();

    public virtual ICollection<Povendsite> Povendsites { get; set; } = new List<Povendsite>();

    public virtual ICollection<QuoteReportVault> QuoteReportVaults { get; set; } = new List<QuoteReportVault>();

    public virtual ICollection<ReportFieldTranslation> ReportFieldTranslations { get; set; } = new List<ReportFieldTranslation>();

    public virtual ICollection<Transport> Transports { get; set; } = new List<Transport>();

    public virtual ICollection<Warehouse> IdLocations { get; set; } = new List<Warehouse>();
}
