using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pjproptype
{
    public string Proptype { get; set; } = null!;

    public string Typedesc { get; set; } = null!;

    public bool DoJobCosting { get; set; }

    public bool IsUtilized { get; set; }

    public bool IsAvailable { get; set; }

    public bool IsInstock { get; set; }

    public bool IsRepair { get; set; }

    public bool ShowInGui { get; set; }

    public double BidFactor { get; set; }

    public string? BidValueType { get; set; }

    public bool IsWarehouseDependent { get; set; }

    public bool IsMissing { get; set; }

    public bool IsTransferring { get; set; }

    public bool IsLeavingWarehouse { get; set; }

    public string DefaultBillSchedule { get; set; } = null!;

    public double BenchmarkFactor { get; set; }

    public bool DoIntercompanyBilling { get; set; }

    public bool IsSale { get; set; }

    public bool IsSalesOrderPropType { get; set; }

    public bool IsCrewBilledViaRfi { get; set; }

    public virtual PartBidValueType? BidValueTypeNavigation { get; set; }

    public virtual PjBillSchedule DefaultBillScheduleNavigation { get; set; } = null!;

    public virtual ICollection<Glentity> Glentities { get; set; } = new List<Glentity>();

    public virtual ICollection<GlentitiesIndexViewTable> GlentitiesIndexViewTables { get; set; } = new List<GlentitiesIndexViewTable>();

    public virtual ICollection<NotificationWarehouseEmailRecipient> NotificationWarehouseEmailRecipients { get; set; } = new List<NotificationWarehouseEmailRecipient>();

    public virtual ICollection<Peempcompany> Peempcompanies { get; set; } = new List<Peempcompany>();

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();
}
