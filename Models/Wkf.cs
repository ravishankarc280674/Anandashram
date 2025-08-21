using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class Wkf
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Osv { get; set; } = null!;

    public bool? OnCreate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<WkfActivity> WkfActivitySubflows { get; set; } = new List<WkfActivity>();

    public virtual ICollection<WkfActivity> WkfActivityWkfs { get; set; } = new List<WkfActivity>();

    public virtual ICollection<WkfInstance> WkfInstances { get; set; } = new List<WkfInstance>();

    public virtual ResUser? WriteU { get; set; }
}
