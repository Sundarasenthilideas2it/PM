using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FileAttachmentIndex
{
    public string FileName { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    public DateTime? CreationTimeUtc { get; set; }

    public Guid Guid { get; set; }

    public string SubFolderPath { get; set; } = null!;

    public byte[] FileNameUnique { get; set; } = null!;

    public string? Entityno { get; set; }

    public string? Partno { get; set; }

    public string? Empno { get; set; }

    public string? UniqueNo { get; set; }

    public string? CreatedBy { get; set; }

    public string? Topic { get; set; }

    public bool IsInKnowledgeBase { get; set; }

    public string? Commodity { get; set; }

    public int? IdManufacturer { get; set; }

    public string? SecondaryCategoryCode { get; set; }

    public int? IdPurchaseOrderInvoice { get; set; }

    public DateTime? DocumentExpirationDateUtc { get; set; }

    public virtual Glentity? EntitynoNavigation { get; set; }

    public virtual Inpart? PartnoNavigation { get; set; }
}
