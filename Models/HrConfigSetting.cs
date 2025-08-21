using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// hr.config.settings
/// </summary>
public partial class HrConfigSetting
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Record contracts per employee
    /// </summary>
    public bool? ModuleHrContract { get; set; }

    /// <summary>
    /// Manage holidays, leaves and allocation requests
    /// </summary>
    public bool? ModuleHrHolidays { get; set; }

    /// <summary>
    /// Manage timesheets
    /// </summary>
    public bool? ModuleHrTimesheet { get; set; }

    /// <summary>
    /// Manage payroll
    /// </summary>
    public bool? ModuleHrPayroll { get; set; }

    /// <summary>
    /// Allow timesheets validation by managers
    /// </summary>
    public bool? ModuleHrTimesheetSheet { get; set; }

    /// <summary>
    /// Install attendances feature
    /// </summary>
    public bool? ModuleHrAttendance { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Organize employees periodic evaluation
    /// </summary>
    public bool? ModuleHrEvaluation { get; set; }

    /// <summary>
    /// Manage employees expenses
    /// </summary>
    public bool? ModuleHrExpense { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Drive engagement with challenges and badges
    /// </summary>
    public bool? ModuleHrGamification { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Allow invoicing based on timesheets (the sale application will be installed)
    /// </summary>
    public bool? ModuleAccountAnalyticAnalysis { get; set; }

    /// <summary>
    /// Manage the recruitment process
    /// </summary>
    public bool? ModuleHrRecruitment { get; set; }

    /// <summary>
    /// Track attendances for all employees
    /// </summary>
    public bool? GroupHrAttendance { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
