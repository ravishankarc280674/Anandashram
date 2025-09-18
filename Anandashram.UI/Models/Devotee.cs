using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anandashram.Models;

[Table("DevoteeHeaders")]
public partial class Devotee
{
    [Key]
    public int Id { get; set; }

    [DisplayName("Code")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string Code { get;private set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [MaxLength(500)]
    public string? Description { get; set; }

    [Required]
    [ForeignKey("DevoteeCategory")]
    [DisplayName("Dev Category")]
    public int DevoteeCategoryId { get; set; }

    [MaxLength(100)]
    public string Mobile { get; set; } = null!;
    [MaxLength(100)]
    public string Email { get; set; } = null!;

    [DisplayName("Address")]
    [MaxLength(200)]
    public string? AddressLine1 { get; set; }

    [MaxLength(200)]
    public string? AddressLine2 { get; set; }

    [MaxLength(100)]
    public string? State { get; set; }
    [MaxLength(100)]
    public string? Country { get; set; }

    [DisplayName("Pin Code")]
    [MaxLength(100)]
    public string? PinCode { get; set; }
    [Required]
    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    [NotMapped]
    [DisplayName("Devotee Category")]
    public string? DevoteeCategoryName { get { return this.DevoteeCategory != null ? DevoteeCategory.Name : string.Empty; } }

    public DevoteeCategory DevoteeCategory { get; set; }
}
