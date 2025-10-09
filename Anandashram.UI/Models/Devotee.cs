using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anandashram.Models;
                           
[Table("Devotees")]
public partial class Devotee
{
    public Devotee()
    {
        ReservationCharts = new List<Reservation>();
    }
    [Key]
    public int Id { get; set; }

    [DisplayName("Code")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string Code { get;set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [MaxLength(500)]
    [DisplayName("Addiional Information")]
    public string? Description { get; set; }

    [Required]
    [ForeignKey("DevoteeCategory")]
    [DisplayName("Category")]
    public int DevoteeCategoryId { get; set; }

    [MaxLength(100)]
    public string Mobile { get; set; } = null!;
    [MaxLength(100)]
    public string Email { get; set; } = null!;

    [DisplayName("Docs(Aaadaar/Pan/..)")]
    public string Document { get; set; }
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

    [DisplayName("CheckIn Date")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
    public DateTime StartDate { get; set; } = DateTime.Now;

    [DisplayName("CheckOut Date")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
    public DateTime EndDate { get; set; } = DateTime.Now;
    [Required]
    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    [Required]
    [DisplayName("Number of People")]
    public int NoOfPeople { get; set; }

    [NotMapped]
    [DisplayName("Devotee Category")]
    public string? DevoteeCategoryName { get { return this.DevoteeCategory != null ? DevoteeCategory.Name : string.Empty; } }

    public DevoteeCategory DevoteeCategory { get; set; }

    public bool Closed { get; set; }

    public string? ReopenedCode { get; set; }

    [NotMapped]

    public List<Reservation> ReservationCharts { get; set; }
}
