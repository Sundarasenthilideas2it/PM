using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjUser
{
    public int IdUser { get; set; }

    public int? IdAddress { get; set; }

    public string? Surname { get; set; }

    public string? FirstName { get; set; }

    public string? Handle { get; set; }

    public string? Password { get; set; }

    public string? Userlevel { get; set; }

    public string? Loginname { get; set; }

    public string? Description { get; set; }

    public long? UserRightmask { get; set; }

    public string? DisplayName { get; set; }

    public int? IdDefaultStock { get; set; }

    public string? Cepassword { get; set; }

    public int? IdOwner { get; set; }

    public string? CrmemailAddress { get; set; }

    public string? CrmemailUser { get; set; }

    public string? CrmemailPsw { get; set; }

    public string? Department { get; set; }
}
