using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.ui.menu
/// </summary>
public partial class IrUiMenu
{
    public int Id { get; set; }

    public int? ParentLeft { get; set; }

    public int? ParentRight { get; set; }

    /// <summary>
    /// Web Icon Image
    /// </summary>
    public byte[]? WebIconData { get; set; }

    /// <summary>
    /// Target model uses the need action mechanism
    /// </summary>
    public bool? NeedactionEnabled { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Menu
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Icon
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Web Icon File (hover)
    /// </summary>
    public string? WebIconHover { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Parent Menu
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Web Icon File
    /// </summary>
    public string? WebIcon { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Web Icon Image (hover)
    /// </summary>
    public byte[]? WebIconHoverData { get; set; }

    /// <summary>
    /// Mail Group
    /// </summary>
    public int? MailGroupId { get; set; }

    public virtual ICollection<BoardCreate> BoardCreates { get; set; } = new List<BoardCreate>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrUiMenu> InverseParent { get; set; } = new List<IrUiMenu>();

    public virtual MailGroup? MailGroup { get; set; }

    public virtual ICollection<MailGroup> MailGroups { get; set; } = new List<MailGroup>();

    public virtual IrUiMenu? Parent { get; set; }

    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreates { get; set; } = new List<WizardIrModelMenuCreate>();

    public virtual ResUser? WriteU { get; set; }
}
