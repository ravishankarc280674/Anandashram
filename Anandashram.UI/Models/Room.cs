namespace Anandashram.Models;
public partial class Room
{

    public Room()
    {
        //Reservations = new List<Reservation>();
    }
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is Required")]
    [DisplayName("Name")]
    [StringLength(100, ErrorMessage = "Max 100 chars allowed")]
    public string Name { get; set; } = null!;

    [DisplayName("Description")]
    [StringLength(500, ErrorMessage = "Max 500 chars allowed")]
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
    public int Remaining { get; set; }
    [NotMapped]
    public int RemainingCount { get
        {
            return Capacity - Occupied;
        }
        }
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
    public List<Reservation> Reservations { get; set; }

    [NotMapped]
    public int Occupied
    {
        get
        {
            if (Reservations != null)
            {
                return Reservations.Sum(r => r.Allocated);
            }
            else return 0;
        }
    }
}
