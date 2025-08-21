using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN hr_employee_category AND hr_employee
/// </summary>
public partial class EmployeeCategoryRel
{
    public int CategoryId { get; set; }

    public int EmpId { get; set; }

    public virtual HrEmployeeCategory Category { get; set; } = null!;

    public virtual HrEmployee Emp { get; set; } = null!;
}
