using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CountryFedExCountryCode
{
    public string Countrycode { get; set; } = null!;

    public string FedExCountryCode { get; set; } = null!;

    public virtual Country CountrycodeNavigation { get; set; } = null!;
}
