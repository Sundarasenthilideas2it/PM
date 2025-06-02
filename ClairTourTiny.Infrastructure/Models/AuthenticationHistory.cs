using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AuthenticationHistory
{
    public string UserId { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdateddAt { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public string? TraceId { get; set; }

    public string JwtToken { get; set; } = null!;

    public string? RefreshToken { get; set; }

    public string? ThirdPartyToken { get; set; }

    public string AuthenticationType { get; set; } = null!;

    public string? ComputerName { get; set; }

    public bool IsActive { get; set; }

    public string AppName { get; set; } = null!;

    public string AppVersion { get; set; } = null!;
}
