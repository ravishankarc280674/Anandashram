using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anandashram.Models;

public partial class Room
{
    

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    
    [Required]
    [ForeignKey("Building")]
    [DisplayName("Building")]
    public int BuildingId { get; set; }


    [Required]
    [ForeignKey("Floor")]
    [DisplayName("Floor")] 
    public int FloorId { get; set; }

    [Required]
    [ForeignKey("Block")]
    [DisplayName("Block")]
    public int BlockId { get; set; }

    [Required]
    public int Capacity { get; set; }
    [NotMapped]
    public int Remaining { get; set; } = 0;
    public string CreatedBy { get; set; } = null!;
    public string? ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public virtual Block Block { get; set; }
    public virtual Building Building { get; set; }
    public virtual Floor Floor { get; set; }

    [NotMapped]
    public string BuildingName { get { if (Building != null) return this.Building.Name; else return string.Empty; } }
    [NotMapped]
    public string BlockName { get { if (Block != null) return this.Block.Name; else return string.Empty; } }
    [NotMapped]
    public string FloorName { get { if (Floor != null) return this.Floor.Name; else return string.Empty; } }
}
