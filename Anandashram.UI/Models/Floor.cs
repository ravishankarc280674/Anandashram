using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public class Floor
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is Required")]
    [DisplayName("Name")]
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)] 
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
