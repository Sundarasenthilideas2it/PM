using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AttachmentType
{
    public string AttachmentType1 { get; set; } = null!;

    public string? AttachmentTypeDescription { get; set; }

    public bool IsInternal { get; set; }

    public bool IsPartAttachment { get; set; }

    public bool IsCompanyAttachment { get; set; }

    public bool IsDeviceAttachment { get; set; }

    public bool IsEmployeeAttachment { get; set; }

    public bool CanHaveExpirationDate { get; set; }

    public string? Parent { get; set; }

    public double? TreeOrder { get; set; }

    public bool? IsShareable { get; set; }

    public virtual ICollection<AttachmentTypeContactCategory> AttachmentTypeContactCategories { get; set; } = new List<AttachmentTypeContactCategory>();

    public virtual ICollection<AttachmentTypeDatabaseRole> AttachmentTypeDatabaseRoles { get; set; } = new List<AttachmentTypeDatabaseRole>();

    public virtual ICollection<DeviceAttachment> DeviceAttachments { get; set; } = new List<DeviceAttachment>();

    public virtual ICollection<EmployeeAttachment> EmployeeAttachments { get; set; } = new List<EmployeeAttachment>();

    public virtual ICollection<GroupPermission> GroupPermissions { get; set; } = new List<GroupPermission>();

    public virtual ICollection<PartAttachment> PartAttachments { get; set; } = new List<PartAttachment>();

    public virtual ICollection<ProjectsAttachmentTypesToCloudStorageFolder> ProjectsAttachmentTypesToCloudStorageFolders { get; set; } = new List<ProjectsAttachmentTypesToCloudStorageFolder>();

    public virtual ICollection<AttachmentCategory> AttachmentCategories { get; set; } = new List<AttachmentCategory>();

    public virtual ICollection<CloudFileStoragePermissionFolderTemplate> CloudFolderTemplates { get; set; } = new List<CloudFileStoragePermissionFolderTemplate>();
}
