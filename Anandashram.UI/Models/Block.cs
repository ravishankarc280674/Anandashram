using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anandashram.Models;

public partial class Block
{
    [Key]
    public int Id { get; set; }



    [Required(ErrorMessage = "Name is Required")]
    [DisplayName("Name")]
    [Column(TypeName = "nvarchar(100)")]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [MaxLength(500)]
    public string? Description { get; set; }
    [MaxLength(100)]
    
    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

}
