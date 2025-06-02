using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AccountFriendlyName
{
    public int FriendlyNameId { get; set; }

    public string FriendlyName { get; set; } = null!;

    public virtual ICollection<TaxAccount> TaxAccounts { get; set; } = new List<TaxAccount>();
}
