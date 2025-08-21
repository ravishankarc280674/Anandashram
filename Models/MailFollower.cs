using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Document Followers
/// </summary>
public partial class MailFollower
{
    public int Id { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string ResModel { get; set; } = null!;

    /// <summary>
    /// Related Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Related Partner
    /// </summary>
    public int PartnerId { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;
}
