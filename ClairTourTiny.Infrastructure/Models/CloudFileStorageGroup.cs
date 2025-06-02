using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStorageGroup
{
    public int IdLevel { get; set; }

    public string LevelDescription { get; set; } = null!;

    public virtual ICollection<CloudFileStoragGroupsToCoreTeam> CloudFileStoragGroupsToCoreTeams { get; set; } = new List<CloudFileStoragGroupsToCoreTeam>();

    public virtual ICollection<ContactCategoriesCloudFileStorageGroup> ContactCategoriesCloudFileStorageGroups { get; set; } = new List<ContactCategoriesCloudFileStorageGroup>();

    public virtual ICollection<CloudFileStoragePermissionFolderTemplate> CloudFolderTemplates { get; set; } = new List<CloudFileStoragePermissionFolderTemplate>();
}
