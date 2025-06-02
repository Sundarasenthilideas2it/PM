using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStorageShareRequestsA
{
    public string? Email { get; set; }

    public string? Entityno { get; set; }

    public string? CloudFolderTemplate { get; set; }

    public string? UserFolderPath { get; set; }

    public bool? IsExecuted { get; set; }

    public bool? IsAddFolderMember { get; set; }

    public bool? IsRemoveFolderMember { get; set; }

    public DateTime? AddFolderMemberTime { get; set; }

    public string? AttachmentCategory { get; set; }

    public DateTime? RemoveFolderMemberTime { get; set; }

    public string? Note { get; set; }

    public bool? IsEgnyteShare { get; set; }

    public DateTime? AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
