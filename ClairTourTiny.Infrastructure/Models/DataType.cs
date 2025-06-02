using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DataType
{
    public string Name { get; set; } = null!;

    public virtual ICollection<AddressDataSourceFieldMap> AddressDataSourceFieldMaps { get; set; } = new List<AddressDataSourceFieldMap>();

    public virtual ICollection<EmailDataSourceFieldMap> EmailDataSourceFieldMaps { get; set; } = new List<EmailDataSourceFieldMap>();

    public virtual ICollection<PaylocityEmail> PaylocityEmails { get; set; } = new List<PaylocityEmail>();

    public virtual ICollection<PaylocityPhone> PaylocityPhones { get; set; } = new List<PaylocityPhone>();

    public virtual ICollection<PhoneDataSourceFieldMap> PhoneDataSourceFieldMaps { get; set; } = new List<PhoneDataSourceFieldMap>();

    public virtual ICollection<PodioEmail> PodioEmails { get; set; } = new List<PodioEmail>();

    public virtual ICollection<PodioPhone> PodioPhones { get; set; } = new List<PodioPhone>();
}
