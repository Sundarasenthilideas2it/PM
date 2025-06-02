using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ApiKey
{
    public string ApiKey1 { get; set; } = null!;

    public string ServiceName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime ExpirationDate { get; set; }

    public string? Scope { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsPublic { get; set; }

    public virtual ICollection<WhiteListedUrl> WhiteListedUrls { get; set; } = new List<WhiteListedUrl>();
}
