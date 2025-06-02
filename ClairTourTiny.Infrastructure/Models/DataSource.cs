using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DataSource
{
    public string Name { get; set; } = null!;

    public int Priority { get; set; }

    public virtual ICollection<AddressDataSourceFieldMap> AddressDataSourceFieldMaps { get; set; } = new List<AddressDataSourceFieldMap>();

    public virtual ICollection<EmailDataSourceFieldMap> EmailDataSourceFieldMaps { get; set; } = new List<EmailDataSourceFieldMap>();

    public virtual ICollection<PhoneDataSourceFieldMap> PhoneDataSourceFieldMaps { get; set; } = new List<PhoneDataSourceFieldMap>();
}
