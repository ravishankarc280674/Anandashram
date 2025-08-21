using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// base.config.settings
/// </summary>
public partial class BaseConfigSetting
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
    /// Attach Google documents to any record
    /// </summary>
    public bool? ModuleGoogleDrive { get; set; }

    /// <summary>
    /// Allow users to import data from CSV files
    /// </summary>
    public bool? ModuleBaseImport { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Activate the customer portal
    /// </summary>
    public bool? ModulePortal { get; set; }

    /// <summary>
    /// Allow the users to synchronize their calendar  with Google Calendar
    /// </summary>
    public bool? ModuleGoogleCalendar { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Allow documents sharing
    /// </summary>
    public bool? ModuleShare { get; set; }

    /// <summary>
    /// Report Font
    /// </summary>
    public int? Font { get; set; }

    /// <summary>
    /// Use external authentication providers, sign in with google, facebook, ...
    /// </summary>
    public bool? ModuleAuthOauth { get; set; }

    /// <summary>
    /// Manage multiple companies
    /// </summary>
    public bool? ModuleMultiCompany { get; set; }

    /// <summary>
    /// Alias Domain
    /// </summary>
    public string? AliasDomain { get; set; }

    /// <summary>
    /// Enable password reset from Login page
    /// </summary>
    public bool? AuthSignupResetPassword { get; set; }

    /// <summary>
    /// Allow external users to sign up
    /// </summary>
    public bool? AuthSignupUninvited { get; set; }

    /// <summary>
    /// Template user for new users created through signup
    /// </summary>
    public int? AuthSignupTemplateUserId { get; set; }

    public virtual ResUser? AuthSignupTemplateUser { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResFont? FontNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
