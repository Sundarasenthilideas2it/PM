using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ContactsStatesCountriesParsedGigme
{
    public long ContactId { get; set; }

    public string Address { get; set; } = null!;

    public string? Piece { get; set; }

    public string? Statecode { get; set; }

    public string? Countrycode { get; set; }

    public string? Countrydesc { get; set; }
}
