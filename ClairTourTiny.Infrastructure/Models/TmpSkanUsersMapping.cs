using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanUsersMapping
{
    public string Userprofileid { get; set; } = null!;

    public string? Name { get; set; }

    public string? Emailaddress { get; set; }

    public string? Passwordhash { get; set; }

    public string? Nickname { get; set; }

    public DateTime? Registrationdate { get; set; }

    public DateTime? Initiallogindate { get; set; }

    public DateTime? Useragreedate { get; set; }

    public string? Notes { get; set; }

    public string? SecretQAns { get; set; }

    public short PasswordChangeRequired { get; set; }

    public short PasswordNeverExpires { get; set; }

    public short IsDeleted { get; set; }

    public short IsSystemUser { get; set; }

    public short IsLocked { get; set; }

    public string? DirectLoginCode { get; set; }

    public string? DefAccordCompId { get; set; }

    public int DefAccordCompHeight { get; set; }

    public string? DefaultGroupid { get; set; }

    public string? FkSecretQ { get; set; }

    public string? ExtAuthenticatorId { get; set; }

    public string? LocaleId { get; set; }

    public string? ApiId { get; set; }

    public string? SecretKey { get; set; }

    public string? SecurityPolicyId { get; set; }

    public string? MobilePinCode { get; set; }

    public DateTime? CreatedByDate { get; set; }

    public string? CreatedByUser { get; set; }

    public DateTime? LastEditDate { get; set; }

    public string? LastEditUser { get; set; }

    public string? UserName { get; set; }
}
