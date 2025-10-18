using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class Building
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is Required")]
    [DisplayName("Name")]
    [StringLength(100, ErrorMessage = "Max 100 chars allowed")]
    public string Name { get; set; } = null!;

    [DisplayName("Description")]
    [StringLength(500, ErrorMessage = "Max 500 chars allowed")]
    public string? Description { get; set; }
    
    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
