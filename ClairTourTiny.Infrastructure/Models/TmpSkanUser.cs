using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanUser
{
    public string Userprofileid { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Emailaddress { get; set; }

    public string? Notes { get; set; }

    public string? DefaultGroupid { get; set; }

    public string? GroupName { get; set; }

    public string? GroupDescription { get; set; }

    public string? FinesseUserName { get; set; }
}
