using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Change Password Wizard
/// </summary>
public partial class ChangePasswordWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<ChangePasswordUser> ChangePasswordUsers { get; set; } = new List<ChangePasswordUser>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
