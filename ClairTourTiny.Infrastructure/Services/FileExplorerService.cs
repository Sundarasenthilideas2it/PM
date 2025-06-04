// using ClairTourTiny.Core.Interfaces;
// using Microsoft.Extensions.Configuration;
// using System;
// using System.Collections.Generic;
// using System.Data;
// using System.Data.SqlClient;
// using System.IO;
// using System.Threading.Tasks;

// namespace ClairTourTiny.Infrastructure.Services
// {
//     public class FileExplorerService : IFileExplorerService
//     {
//         private readonly string _connectionString;

//         public FileExplorerService(IConfiguration configuration)
//         {
//             _connectionString = configuration.GetConnectionString("FinesseConnection");
//         }

//         public async Task<string> GetFinesseDataRootDirectory()
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();
//             var command = new SqlCommand("select s.value from sysconfig s where s.tag = 'GLOBAL_OPS_FINESSE_DATA_ROOT_DIRECTORY'", conn);
//             return (await command.ExecuteScalarAsync())?.ToString();
//         }

//         public async Task<string> GetProjectAttachmentFilePath(string entityNo, string attachmentTypeCode)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();
            
//             var attachmentCategory = "Projects";
//             var folderPath = string.Empty;
//             var guid = string.Empty;

//             // Get GUID
//             var guidCommand = new SqlCommand("select g.GUID from dbo.glentities g where entityno = @entityNo", conn);
//             guidCommand.Parameters.AddWithValue("@entityNo", entityNo);
//             guid = (await guidCommand.ExecuteScalarAsync())?.ToString();

//             if (string.IsNullOrEmpty(guid))
//                 throw new Exception("Entity not found");

//             // Get attachment type info
//             var attachmentTypeCommand = new SqlCommand(@"
//                 SELECT act.AttachmentCategory, at.AttachmentTypeDescription, 
//                        Permissionsneeded = is_rolemember(DatabaseRole), 
//                        act.AttachmentType, cfsgtat.CloudFolderTemplate,
//                        CASE ISNULL(is_rolemember(DatabaseRole), 1)
//                            WHEN 0 THEN 0
//                            ELSE 1
//                        END AS hasPermissions,
//                        dbo.fn_get_attachmentTypeFullPath(at.AttachmentType) as FullAttachmentPath
//                 FROM dbo.AttachmentCategoryTypes act
//                 JOIN dbo.AttachmentTypes at ON act.AttachmentType = at.AttachmentType
//                 LEFT OUTER JOIN dbo.CloudFileStorageGroupsToAttachmentTypes cfsgtat 
//                     ON cfsgtat.AttachmentType = at.AttachmentType
//                 LEFT OUTER JOIN dbo.AttachmentTypeDatabaseRoles atb 
//                     ON atb.AttachmentType = at.AttachmentType
//                 WHERE act.AttachmentCategory = @category 
//                 AND act.AttachmentType = @typeCode", conn);

//             attachmentTypeCommand.Parameters.AddWithValue("@category", attachmentCategory);
//             attachmentTypeCommand.Parameters.AddWithValue("@typeCode", attachmentTypeCode);

//             using var reader = await attachmentTypeCommand.ExecuteReaderAsync();
//             if (!await reader.ReadAsync())
//                 throw new Exception("Attachment type not found");

//             var attachmentTypeDescription = reader["AttachmentTypeDescription"].ToString();
//             var fullAttachmentPath = reader["FullAttachmentPath"].ToString();

//             folderPath = await GetAttachmentTypeFolderPath(guid, attachmentCategory);
//             var rootFolderPath = folderPath;
//             folderPath = Path.Combine(folderPath, fullAttachmentPath);

//             if (!Directory.Exists(folderPath))
//             {
//                 await CreateFileStoragePathsEntry(rootFolderPath, guid);
//                 await CreateFolderDBEntry(reader, entityNo);
//                 await CreateSubDirectories(new DirectoryInfo(folderPath), reader, attachmentCategory);
//             }

//             return folderPath;
//         }

//         public async Task<string> GetEmployeeAttachmentFolderPath(string empNo, string attachmentTypeCode)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();
            
//             var attachmentCategory = "Employees";
//             var folderPath = string.Empty;
//             var guid = string.Empty;

//             // Get GUID
//             var guidCommand = new SqlCommand("select p.GUID from dbo.peemployee p where p.empno = @empNo", conn);
//             guidCommand.Parameters.AddWithValue("@empNo", empNo);
//             guid = (await guidCommand.ExecuteScalarAsync())?.ToString();

//             if (string.IsNullOrEmpty(guid))
//                 throw new Exception("Employee not found");

//             // Get attachment type info
//             var attachmentTypeCommand = new SqlCommand(@"
//                 SELECT act.AttachmentCategory, at.AttachmentTypeDescription,
//                        Permissionsneeded = is_rolemember(DatabaseRole),
//                        act.AttachmentType, atb.DatabaseRole,
//                        CASE ISNULL(is_rolemember(DatabaseRole), 1)
//                            WHEN 0 THEN 0
//                            ELSE 1
//                        END AS hasPermissions
//                 FROM dbo.AttachmentCategoryTypes act
//                 JOIN dbo.AttachmentTypes at ON act.AttachmentType = at.AttachmentType
//                 LEFT OUTER JOIN dbo.AttachmentTypeDatabaseRoles atb 
//                     ON atb.AttachmentType = at.AttachmentType
//                 WHERE act.AttachmentCategory = @category 
//                 AND act.AttachmentType = @typeCode", conn);

//             attachmentTypeCommand.Parameters.AddWithValue("@category", attachmentCategory);
//             attachmentTypeCommand.Parameters.AddWithValue("@typeCode", attachmentTypeCode);

//             using var reader = await attachmentTypeCommand.ExecuteReaderAsync();
//             if (!await reader.ReadAsync())
//                 throw new Exception("Attachment type not found");

//             var attachmentTypeDescription = reader["AttachmentTypeDescription"].ToString();

//             folderPath = await GetAttachmentTypeFolderPath(guid, attachmentCategory);
//             var rootFolderPath = folderPath;
//             folderPath = Path.Combine(folderPath, attachmentTypeDescription);

//             if (!Directory.Exists(folderPath))
//             {
//                 await CreateFileStoragePathsEntry(rootFolderPath, guid);
//                 await CreateSubDirectories(new DirectoryInfo(folderPath), reader, attachmentCategory);
//             }

//             return folderPath;
//         }

//         public async Task<Dictionary<string, string>> GetCustomerOrderAttachmentFolderPath(string orderNo, string attachmentTypeCode)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();
            
//             var attachmentCategory = "CustomerOrders";
//             var folderPath = string.Empty;
//             var guid = string.Empty;

//             // Get GUID
//             var guidCommand = new SqlCommand("select o.fileStorageGUID from dbo.oecohead o where o.orderno = @orderNo", conn);
//             guidCommand.Parameters.AddWithValue("@orderNo", orderNo);
//             guid = (await guidCommand.ExecuteScalarAsync())?.ToString();

//             if (string.IsNullOrEmpty(guid))
//                 throw new Exception("Order not found");

//             // Get attachment type info
//             var attachmentTypeCommand = new SqlCommand(@"
//                 SELECT act.AttachmentCategory, at.AttachmentTypeDescription,
//                        Permissionsneeded = is_rolemember(DatabaseRole),
//                        act.AttachmentType, atb.DatabaseRole,
//                        CASE ISNULL(is_rolemember(DatabaseRole), 1)
//                            WHEN 0 THEN 0
//                            ELSE 1
//                        END AS hasPermissions
//                 FROM dbo.AttachmentCategoryTypes act
//                 JOIN dbo.AttachmentTypes at ON act.AttachmentType = at.AttachmentType
//                 LEFT OUTER JOIN dbo.AttachmentTypeDatabaseRoles atb 
//                     ON atb.AttachmentType = at.AttachmentType
//                 WHERE act.AttachmentCategory = @category 
//                 AND act.AttachmentType = @typeCode", conn);

//             attachmentTypeCommand.Parameters.AddWithValue("@category", attachmentCategory);
//             attachmentTypeCommand.Parameters.AddWithValue("@typeCode", attachmentTypeCode);

//             using var reader = await attachmentTypeCommand.ExecuteReaderAsync();
//             if (!await reader.ReadAsync())
//                 throw new Exception("Attachment type not found");

//             var attachmentTypeDescription = reader["AttachmentTypeDescription"].ToString();

//             folderPath = await GetAttachmentTypeFolderPath(guid, attachmentCategory);
//             var rootFolderPath = folderPath;
//             folderPath = Path.Combine(folderPath, attachmentTypeDescription);

//             if (!Directory.Exists(folderPath))
//             {
//                 await CreateFileStoragePathsEntry(rootFolderPath, guid);
//                 await CreateSubDirectories(new DirectoryInfo(folderPath), reader, attachmentCategory);
//             }

//             return new Dictionary<string, string>
//             {
//                 { "GUID", guid },
//                 { "folderPath", folderPath }
//             };
//         }

//         public string GetProjectRootPhaseNumber(string fullEntityNo)
//         {
//             var characterstoCutoff = fullEntityNo.IndexOf("-", fullEntityNo.IndexOf("-") + 1);
//             return characterstoCutoff != -1 ? fullEntityNo.Remove(characterstoCutoff) : fullEntityNo;
//         }

//         public string CleanFileOrFolderName(string filePath)
//         {
//             var cleanName = filePath;
//             foreach (var c in Path.GetInvalidFileNameChars())
//             {
//                 cleanName = cleanName.Replace(c.ToString(), "");
//             }
//             return cleanName;
//         }

//         public async Task<string> GetDefaultRootPathForAttachmentCategory(string attachmentCategory)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();
//             var command = new SqlCommand(
//                 "select ac.defaultRootFolderPath from dbo.AttachmentCategory AS ac WHERE ac.AttachmentCategory = @category",
//                 conn);
//             command.Parameters.AddWithValue("@category", attachmentCategory);
//             return (await command.ExecuteScalarAsync())?.ToString();
//         }

//         private async Task<string> GetAttachmentTypeFolderPath(string fileStorageGUID, string attachmentCategory)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();

//             // Check for existing path
//             var pathCommand = new SqlCommand(
//                 "select fsp.fileStoragePath from dbo.fileStoragePaths AS fsp WHERE fsp.fileStorageGUID = @guid",
//                 conn);
//             pathCommand.Parameters.AddWithValue("@guid", fileStorageGUID);
//             var existingPath = (await pathCommand.ExecuteScalarAsync())?.ToString();

//             if (!string.IsNullOrEmpty(existingPath))
//                 return existingPath;

//             // Get default path
//             var defaultPathCommand = new SqlCommand("dbo.get_default_file_Storage_path", conn);
//             defaultPathCommand.CommandType = CommandType.StoredProcedure;
//             defaultPathCommand.Parameters.AddWithValue("@GUID", new Guid(fileStorageGUID));
//             defaultPathCommand.Parameters.AddWithValue("@AttachmentType", attachmentCategory);
//             var pathParam = new SqlParameter("@path", SqlDbType.VarChar, 255) { Direction = ParameterDirection.Output };
//             defaultPathCommand.Parameters.Add(pathParam);

//             await defaultPathCommand.ExecuteNonQueryAsync();
//             return pathParam.Value?.ToString();
//         }

//         private async Task CreateFileStoragePathsEntry(string folderPath, string fileStorageGUID)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();
//             var command = new SqlCommand("dbo.createFileStoragePathEntry", conn);
//             command.CommandType = CommandType.StoredProcedure;
//             command.Parameters.AddWithValue("@folderPath", folderPath);
//             command.Parameters.AddWithValue("@GUID", new Guid(fileStorageGUID));
//             await command.ExecuteNonQueryAsync();
//         }

//         private async Task CreateFolderDBEntry(SqlDataReader attachmentTypeRow, string entityNo)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();

//             // Check if entry already exists
//             var checkCommand = new SqlCommand(@"
//                 SELECT puftcsf.entityno, puftcsf.UserFolderPath
//                 FROM dbo.ProjectsUsersFoldersToCloudStorageFolders AS puftcsf
//                 WHERE puftcsf.entityno = @entityNo 
//                 AND puftcsf.AttachmentType = @attachmentType", conn);
            
//             checkCommand.Parameters.AddWithValue("@entityNo", entityNo);
//             checkCommand.Parameters.AddWithValue("@attachmentType", attachmentTypeRow["AttachmentType"]);

//             if (await checkCommand.ExecuteScalarAsync() != null)
//                 return;

//             // Get cloud folder template info
//             var templateCommand = new SqlCommand(@"
//                 SELECT c.AttachmentType, c.CloudFolderTemplate
//                 FROM dbo.CloudFileStorageGroupsToAttachmentTypes c
//                 WHERE c.AttachmentType = @attachmentType", conn);
            
//             templateCommand.Parameters.AddWithValue("@attachmentType", attachmentTypeRow["AttachmentType"]);

//             using var templateReader = await templateCommand.ExecuteReaderAsync();
//             if (!await templateReader.ReadAsync())
//                 return;

//             var idLevel = await GetIDLevelFromTemplateType(templateReader["CloudFolderTemplate"].ToString());

//             // Create new entry
//             var insertCommand = new SqlCommand(@"
//                 INSERT dbo.ProjectsUsersFoldersToCloudStorageFolders
//                 (entityno, UserFolderPath, CloudFolderTemplate, id_Level, AttachmentType)
//                 VALUES
//                 (@entityNo, @userFolderPath, @cloudFolderTemplate, @idLevel, @attachmentType)", conn);

//             insertCommand.Parameters.AddWithValue("@entityNo", entityNo);
//             insertCommand.Parameters.AddWithValue("@userFolderPath", attachmentTypeRow["AttachmentTypeDescription"]);
//             insertCommand.Parameters.AddWithValue("@cloudFolderTemplate", templateReader["CloudFolderTemplate"]);
//             insertCommand.Parameters.AddWithValue("@idLevel", idLevel);
//             insertCommand.Parameters.AddWithValue("@attachmentType", attachmentTypeRow["AttachmentType"]);

//             await insertCommand.ExecuteNonQueryAsync();
//         }

//         private async Task CreateSubDirectories(DirectoryInfo info, SqlDataReader attachmentTypeRow, string attachmentCategory)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();

//             var permissionsCommand = new SqlCommand(@"
//                 SELECT gp.groupName, gp.AttachmentType, gp.allowFullControl, gp.allowModify,
//                        gp.[allowRead&Execute], gp.allowListFolderContents, gp.allowRead,
//                        gp.allowWrite, gp.allowSpecialPermissions, fpg.GroupPath
//                 FROM dbo.GroupPermissions gp
//                 JOIN dbo.FilePermissionsGroups fpg ON fpg.GroupName = gp.GroupName
//                 JOIN dbo.AttachmentCategoryTypes act ON act.AttachmentType = gp.AttachmentType
//                 WHERE act.AttachmentCategory = @category 
//                 AND act.attachmentType = @type", conn);

//             permissionsCommand.Parameters.AddWithValue("@category", attachmentCategory);
//             permissionsCommand.Parameters.AddWithValue("@type", attachmentTypeRow["AttachmentType"]);

//             using var reader = await permissionsCommand.ExecuteReaderAsync();
//             var newDir = info.ToString();
//             Directory.CreateDirectory(newDir);

//             // Note: Folder permissions are now handled by the egnyte poller
//             // The original code for setting permissions has been commented out as per the original implementation
//         }

//         private async Task<int> GetIDLevelFromTemplateType(string template)
//         {
//             using var conn = new SqlConnection(_connectionString);
//             await conn.OpenAsync();

//             var command = new SqlCommand(@"
//                 SELECT cfsgtpf.CloudFolderTemplate, cfsgtpf.id_Level 
//                 FROM dbo.CloudFileStorageGroupsToPermissionFolders AS cfsgtpf
//                 WHERE cfsgtpf.CloudFolderTemplate = @template", conn);
            
//             command.Parameters.AddWithValue("@template", template);

//             using var reader = await command.ExecuteReaderAsync();
//             var idLevel = 100;

//             while (await reader.ReadAsync())
//             {
//                 var currentLevel = Convert.ToInt32(reader["id_Level"]);
//                 if (idLevel > currentLevel)
//                     idLevel = currentLevel;
//             }

//             return idLevel;
//         }
//     }
// } 