using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Job Position
/// </summary>
public partial class HrJob
{
    public int Id { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Requirements
    /// </summary>
    public string? Requirements { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Total Forecasted Employees
    /// </summary>
    public int? ExpectedEmployees { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Job Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Update Date
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Job Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Expected New Employees
    /// </summary>
    public int? NoOfRecruitment { get; set; }

    /// <summary>
    /// Hired Employees
    /// </summary>
    public int? NoOfHiredEmployee { get; set; }

    /// <summary>
    /// Current Number of Employees
    /// </summary>
    public int? NoOfEmployee { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ResUser? WriteU { get; set; }
}
