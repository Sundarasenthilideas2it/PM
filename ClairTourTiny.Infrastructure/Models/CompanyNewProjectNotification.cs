using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CompanyNewProjectNotification
{
    public string CompanyCode { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;
}
