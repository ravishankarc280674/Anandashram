using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// base_import.tests.models.m2o
/// </summary>
public partial class BaseImportTestsModelsM2o
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
    /// unknown
    /// </summary>
    public int? Value { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual BaseImportTestsModelsM2oRelated? ValueNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
