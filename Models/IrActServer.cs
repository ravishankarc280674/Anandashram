using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrActServer
{
    public int Id { get; set; }

    public int? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Help { get; set; }

    public int? WriteUid { get; set; }

    public DateTime? WriteDate { get; set; }

    public string? Usage { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    /// <summary>
    /// Python Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Target Model
    /// </summary>
    public int? CrudModelId { get; set; }

    /// <summary>
    /// Condition
    /// </summary>
    public string? Condition { get; set; }

    /// <summary>
    /// Reference record
    /// </summary>
    public string? RefObject { get; set; }

    /// <summary>
    /// Record
    /// </summary>
    public string? IdObject { get; set; }

    /// <summary>
    /// Create/Write Target Model Name
    /// </summary>
    public string? CrudModelName { get; set; }

    /// <summary>
    /// Target Model
    /// </summary>
    public string UseRelationalModel { get; set; } = null!;

    /// <summary>
    /// Creation Policy
    /// </summary>
    public string UseCreate { get; set; } = null!;

    /// <summary>
    /// Relation Field
    /// </summary>
    public int? WkfFieldId { get; set; }

    /// <summary>
    /// Target Model
    /// </summary>
    public int? WkfModelId { get; set; }

    /// <summary>
    /// Action To Do
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Record ID
    /// </summary>
    public string? IdValue { get; set; }

    /// <summary>
    /// Client Action
    /// </summary>
    public int? ActionId { get; set; }

    /// <summary>
    /// Base Model
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Sub-field
    /// </summary>
    public int? SubModelObjectField { get; set; }

    /// <summary>
    /// Attach the new record
    /// </summary>
    public bool? LinkNewRecord { get; set; }

    /// <summary>
    /// Signal to Trigger
    /// </summary>
    public int? WkfTransitionId { get; set; }

    /// <summary>
    /// Sub-model
    /// </summary>
    public int? SubObject { get; set; }

    /// <summary>
    /// Update Policy
    /// </summary>
    public string UseWrite { get; set; } = null!;

    /// <summary>
    /// Target Model Name
    /// </summary>
    public string? WkfModelName { get; set; }

    /// <summary>
    /// Placeholder Expression
    /// </summary>
    public string? Copyvalue { get; set; }

    /// <summary>
    /// Expression
    /// </summary>
    public string? WriteExpression { get; set; }

    /// <summary>
    /// More Menu entry
    /// </summary>
    public int? MenuIrValuesId { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int? ModelObjectField { get; set; }

    /// <summary>
    /// Link using field
    /// </summary>
    public int? LinkFieldId { get; set; }

    /// <summary>
    /// Email Template
    /// </summary>
    public int? TemplateId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel? CrudModel { get; set; }

    public virtual ICollection<FetchmailServer> FetchmailServers { get; set; } = new List<FetchmailServer>();

    public virtual ICollection<IrServerObjectLine> IrServerObjectLines { get; set; } = new List<IrServerObjectLine>();

    public virtual IrModelField? LinkField { get; set; }

    public virtual IrValue? MenuIrValues { get; set; }

    public virtual IrModel Model { get; set; } = null!;

    public virtual IrModelField? ModelObjectFieldNavigation { get; set; }

    public virtual IrModelField? SubModelObjectFieldNavigation { get; set; }

    public virtual IrModel? SubObjectNavigation { get; set; }

    public virtual EmailTemplate? Template { get; set; }

    public virtual ICollection<WkfActivity> WkfActivities { get; set; } = new List<WkfActivity>();

    public virtual IrModelField? WkfField { get; set; }

    public virtual IrModel? WkfModel { get; set; }

    public virtual WkfTransition? WkfTransition { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
