using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UserPreference
{
    public string UserName { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public object? Value { get; set; }

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;
}
