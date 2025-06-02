using AutoMapper;
using ClairTourTiny.Core.Helpers;
using ClairTourTiny.Core.Models.ProjectMaintenance.Save;
using ClairTourTiny.Infrastructure.Models;
using ClairTourTiny.Infrastructure.Models.ProjectMaintenance;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ClairTourTiny.Infrastructure.Helpers;

public class ProjectMaintenanceHelper : IProjectMaintenanceHelper
{
    public async Task ProcessAllBulkSaves(ProjectSaveModel model, IMapper mapper, ClairTourTinyContext context)
    {
        var bulkOperations = GetBulkSaveOperations(model);

        foreach (var (sourceList, sourceType, destType) in bulkOperations)
        {
            if (sourceList == null || !sourceList.Cast<object>().Any())
                continue;

            var mappedList = mapper.Map(
                sourceList,
                sourceType,
                typeof(List<>).MakeGenericType(destType)
            ) as IEnumerable<object> ?? [];

            foreach (var entity in mappedList)
            {
                var insertSql = GenerateInsertSql(context,destType, sourceType, entity, out var parameters);
                await context.Database.ExecuteSqlRawAsync(insertSql, parameters);
            }
        }
    }

    private List<(IEnumerable<object> Source, Type SourceType, Type DestType)> GetBulkSaveOperations(ProjectSaveModel model)
    {
        return new List<(IEnumerable<object> Source, Type SourceType, Type DestType)>
        {
            (model.Projects, typeof(ProjectModel), typeof(Pm2Project)),
            (model.Equipment, typeof(Equipment), typeof(Pm2Equipment)),
            (model.Crew, typeof(Crew), typeof(Pm2Crew)),
            (model.AssignedCrew, typeof(AssignedCrew), typeof(Pm2AssignedCrew)),
            (model.RFIs, typeof(RfiModel), typeof(Pm2Rfi)),
            (model.BidExpenses, typeof(BidExpense), typeof(Pm2BidExpense)),
            (model.BidRevenue, typeof(BidRevenue), typeof(Pm2BidRevenue)),
            (model.ProjectNotes, typeof(ProjectNote), typeof(Pm2ProjectNote)),
            (model.ProjectBillingPeriods, typeof(Core.Models.ProjectMaintenance.Save.ProjectBillingPeriod), typeof(Pm2ProjectBillingPeriod)),
            (model.ProjectClientContacts, typeof(Core.Models.ProjectMaintenance.Save.ProjectClientContact), typeof(Pm2ProjectClientContact)),
            (model.ProjectEmployeeOvertimeRates, typeof(Core.Models.ProjectMaintenance.Save.ProjectEmployeeOvertimeRate), typeof(Pm2ProjectEmployeeOvertimeRate)),
            (model.ProjectBillingPeriodItems, typeof(Core.Models.ProjectMaintenance.Save.ProjectBillingPeriodItem), typeof(Pm2ProjectBillingPeriodItem)),
            (model.ProjectProductionSchedule, typeof(Core.Models.ProjectMaintenance.Save.ProjectProductionSchedule), typeof(Pm2ProjectProductionSchedule)),
            (model.ProjectBillingItems, typeof(Core.Models.ProjectMaintenance.Save.ProjectBillingItem), typeof(Pm2ProjectBillingItem)),
            (model.FavoriteProjects, typeof(FavoriteProject), typeof(Pm2FavoriteProjects)),
            (model.EquipmentSubhires, typeof(ProjectEquipmentSubhireModel), typeof(Pm2EquipmentSubhire))
        };
    }

    private string GenerateInsertSql(ClairTourTinyContext context,Type entityType, Type sourceType, object entity, out object[] parameters)
    {
        var sourceProperties = sourceType.GetProperties().Select(p => p.Name).ToHashSet();
        var propertiesWithValues = entityType.GetProperties()
            .Where(p => !typeof(IEnumerable<>).IsAssignableFrom(p.PropertyType))
            .Where(p => sourceProperties.Contains(p.Name))
            .Select((p, i) => new { Property = p, Value = p.GetValue(entity), Index = i })
            .ToList();

        var entityMetadata = context.Model.FindEntityType(entityType);

        var columnNames = propertiesWithValues
            .Select(x => entityMetadata?.FindProperty(x.Property.Name)?.GetColumnName() ?? x.Property.Name)
            .ToList();

        var paramNames = propertiesWithValues.Select((x, i) => $"@p{i}").ToList();

        parameters = propertiesWithValues
            .Select((x, i) => CreateSqlParameter($"@p{i}", x.Property.PropertyType, x.Value))
            .ToArray();

        var tableName = entityMetadata?.GetTableName() ?? entityType.Name;
        var schema = entityMetadata?.GetSchema() ?? "dbo";

        var insertSql = $"INSERT INTO [{schema}].[{tableName}] ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", paramNames)})";

        return insertSql;
    }

    private SqlParameter CreateSqlParameter(string paramName, Type propertyType, object value)
    {
        var underlyingType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;

        var sqlDbType = GetSqlDbType(underlyingType);
        var parameter = new SqlParameter(paramName, sqlDbType)
        {
            Value = value ?? DBNull.Value
        };

        if (underlyingType == typeof(decimal))
        {
            parameter.Precision = 18;
            parameter.Scale = 2;
        }
        else if (underlyingType == typeof(DateTime))
        {
            if (value is DateTime dateTime)
            {
                parameter.Value = dateTime.ToString("yyyy-MM-dd");
            }
        }

        return parameter;
    }

    private SqlDbType GetSqlDbType(Type type)
    {
        if (type == typeof(string))
            return SqlDbType.NVarChar;
        else if (type == typeof(int))
            return SqlDbType.Int;
        else if (type == typeof(long))
            return SqlDbType.BigInt;
        else if (type == typeof(decimal))
            return SqlDbType.Decimal;
        else if (type == typeof(DateTime))
            return SqlDbType.DateTime2;
        else if (type == typeof(bool))
            return SqlDbType.Bit;
        else if (type == typeof(double))
            return SqlDbType.Float;
        else if (type == typeof(short))
            return SqlDbType.SmallInt;
        else if (type == typeof(byte))
            return SqlDbType.TinyInt;
        else if (type == typeof(Guid))
            return SqlDbType.UniqueIdentifier;
        else if (type == typeof(DateOnly))
            return SqlDbType.Date;
        else if (type == typeof(TimeOnly))
            return SqlDbType.Time;
        else
            return SqlDbType.Variant;
    }
}