using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// hr.department
/// </summary>
public partial class HrDepartment
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
    /// Department Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Parent Department
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Manager
    /// </summary>
    public int? ManagerId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrDepartment> InverseParent { get; set; } = new List<HrDepartment>();

    public virtual HrEmployee? Manager { get; set; }

    public virtual HrDepartment? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
