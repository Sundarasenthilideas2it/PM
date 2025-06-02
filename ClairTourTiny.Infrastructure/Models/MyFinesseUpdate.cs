using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseUpdate
{
    public int IdMyFinesseUpdate { get; set; }

    public DateTime Date { get; set; }

    public string Topic { get; set; } = null!;

    public string? Packagecd { get; set; }

    public string? Cmndsel { get; set; }

    public string Note { get; set; } = null!;

    public string UseridAuthor { get; set; } = null!;

    public string? Hyperlink { get; set; }

    public virtual Mumenu? Mumenu { get; set; }

    public virtual Pjtfrusr UseridAuthorNavigation { get; set; } = null!;
}
