using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrModelDatum
{
    public int Id { get; set; }

    public int? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public int? WriteUid { get; set; }

    public bool? Noupdate { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? DateInit { get; set; }

    public DateTime? DateUpdate { get; set; }

    public string Module { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int? ResId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrUiView> IrUiViews { get; set; } = new List<IrUiView>();

    public virtual ResUser? WriteU { get; set; }
}
