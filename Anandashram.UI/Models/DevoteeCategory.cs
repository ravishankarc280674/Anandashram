namespace Anandashram.Models;

[Table("DevoteeCategories")]
public partial class DevoteeCategory
{


    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is Required")]
    [DisplayName("Name")]
    [Column(TypeName ="nvarchar(100)")]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [DisplayName("Description")]
    [Column(TypeName = "nvarchar(250)")]
    [MaxLength(250)] 
    public string? Description { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
    public ICollection<Devotee> Devotees { get; set; }
}
