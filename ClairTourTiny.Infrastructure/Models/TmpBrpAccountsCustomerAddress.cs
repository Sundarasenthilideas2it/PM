using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBrpAccountsCustomerAddress
{
    public string? CustomerCode { get; set; }

    public string? AddressNumber { get; set; }

    public string? Address { get; set; }

    public string? Town { get; set; }

    public string? County { get; set; }

    public string? PostCode { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? MobilePhone { get; set; }

    public string? EMailAddress { get; set; }

    public double? DefaultInvoiceAddress { get; set; }

    public double? DefaultDeliveryAddress { get; set; }

    public double? DefaultStatementAddress { get; set; }

    public string? UserIdLastEdited { get; set; }

    public string? UserIdEntered { get; set; }

    public DateOnly? DateEntered { get; set; }

    public DateOnly? DateLastEdited { get; set; }

    public string? SalesAnalysis { get; set; }

    public string? Source { get; set; }

    public string? Country { get; set; }

    public string? CcEMailAddress { get; set; }

    public string? VatRegistrationCode { get; set; }

    public string? VatStatus { get; set; }

    public string? CountryCode { get; set; }
}
