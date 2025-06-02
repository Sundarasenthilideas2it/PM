using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBrpAccountsCustomer
{
    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? SortKey { get; set; }

    public string? UserSort1 { get; set; }

    public string? UserSort2 { get; set; }

    public string? Address { get; set; }

    public string? Town { get; set; }

    public string? County { get; set; }

    public string? PostCode { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Mobile { get; set; }

    public string? EMailAddress { get; set; }

    public string? Country { get; set; }

    public string? CurrencyCode { get; set; }

    public string? CountryCode { get; set; }

    public DateOnly? DateOfLastInvoice { get; set; }
}
