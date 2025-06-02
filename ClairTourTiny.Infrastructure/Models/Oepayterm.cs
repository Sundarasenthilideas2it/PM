using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Oepayterm
{
    public string Paytermscd { get; set; } = null!;

    public string? Paytermsdesc { get; set; }

    public string EomInd { get; set; } = null!;

    public int DiscDays { get; set; }

    public string DiscFxpc { get; set; } = null!;

    public double DiscRate { get; set; }

    public int NetDays { get; set; }

    public string Agesource { get; set; } = null!;

    public int Age1 { get; set; }

    public int Age2 { get; set; }

    public int Age3 { get; set; }

    public int Age4 { get; set; }

    public int Age5 { get; set; }

    public string Finsource { get; set; } = null!;

    public string Finfxpc { get; set; } = null!;

    public double Finrate { get; set; }

    public string Finmatrixcd { get; set; } = null!;

    public string Dunsource { get; set; } = null!;

    public int Dundays { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public bool IsActive { get; set; }

    public string BaseDatecd { get; set; } = null!;

    public string? IfstermsCode { get; set; }

    public virtual OePayTermsNetDaysBaseDate BaseDatecdNavigation { get; set; } = null!;

    public virtual ICollection<InvoiceSeries> InvoiceSeries { get; set; } = new List<InvoiceSeries>();

    public virtual ICollection<InvoiceSeriesStagingVault> InvoiceSeriesStagingVaults { get; set; } = new List<InvoiceSeriesStagingVault>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<IfspaymentTerm> IfstermsCodes { get; set; } = new List<IfspaymentTerm>();
}
