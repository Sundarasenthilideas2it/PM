using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EquipmentOwner
{
    public string OwnerCode { get; set; } = null!;

    public string OwnerDesc { get; set; } = null!;

    public string? CompanyCode { get; set; }

    public bool AllowAddNewEquipment { get; set; }

    public bool IncludeInJobCosting { get; set; }

    public bool DoIntercompanyBilling { get; set; }

    public bool IsVisible { get; set; }

    public bool EnableZebraPrinting { get; set; }

    public string? BarcodeSequenceType { get; set; }

    public virtual Company? CompanyCodeNavigation { get; set; }

    public virtual ICollection<Inpartsub> Inpartsubs { get; set; } = new List<Inpartsub>();

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
