using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WhiteListedUrl
{
    public Guid Id { get; set; }

    public string ApiKey { get; set; } = null!;

    public string Url { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsActive { get; set; }

    public virtual ApiKey ApiKeyNavigation { get; set; } = null!;
}
