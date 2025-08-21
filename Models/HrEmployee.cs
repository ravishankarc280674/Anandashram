using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Employee
/// </summary>
public partial class HrEmployee
{
    public int Id { get; set; }

    /// <summary>
    /// Working Address
    /// </summary>
    public int? AddressId { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Coach
    /// </summary>
    public int? CoachId { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    public int ResourceId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Photo
    /// </summary>
    public byte[]? Image { get; set; }

    /// <summary>
    /// Marital Status
    /// </summary>
    public string? Marital { get; set; }

    /// <summary>
    /// Identification No
    /// </summary>
    public string? IdentificationId { get; set; }

    /// <summary>
    /// Bank Account Number
    /// </summary>
    public int? BankAccountId { get; set; }

    /// <summary>
    /// Job Title
    /// </summary>
    public int? JobId { get; set; }

    /// <summary>
    /// Work Phone
    /// </summary>
    public string? WorkPhone { get; set; }

    /// <summary>
    /// Nationality
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Manager
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Other Id
    /// </summary>
    public string? Otherid { get; set; }

    /// <summary>
    /// Work Mobile
    /// </summary>
    public string? MobilePhone { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Date of Birth
    /// </summary>
    public DateOnly? Birthday { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// SIN No
    /// </summary>
    public string? Sinid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Work Email
    /// </summary>
    public string? WorkEmail { get; set; }

    /// <summary>
    /// Office Location
    /// </summary>
    public string? WorkLocation { get; set; }

    /// <summary>
    /// Medium-sized photo
    /// </summary>
    public byte[]? ImageMedium { get; set; }

    /// <summary>
    /// Gender
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// SSN No
    /// </summary>
    public string? Ssnid { get; set; }

    /// <summary>
    /// Small-sized photo
    /// </summary>
    public byte[]? ImageSmall { get; set; }

    /// <summary>
    /// Home Address
    /// </summary>
    public int? AddressHomeId { get; set; }

    /// <summary>
    /// Passport No
    /// </summary>
    public string? PassportId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? NameRelated { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Roll number
    /// </summary>
    public string? Code { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual ResPartner? AddressHome { get; set; }

    public virtual ResPartnerBank? BankAccount { get; set; }

    public virtual HrEmployee? Coach { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual ICollection<HrAttendance> HrAttendances { get; set; } = new List<HrAttendance>();

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrEmployee> InverseCoach { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> InverseParent { get; set; } = new List<HrEmployee>();

    public virtual HrJob? Job { get; set; }

    public virtual HrEmployee? Parent { get; set; }

    public virtual ResourceResource Resource { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
