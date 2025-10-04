namespace Anandashram.Models
{
    public class ReservationChart
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("DevoteeHeader")]
        public int DevoteeId { get; set; }
        public virtual Devotee Devotee { get; private set; }

        [Required]
        [ForeignKey("Building")]
        public string BuildingId { get; set; }
        [Required]
        [ForeignKey("Block")]
        public string BlockId { get; set; }
        [Required]
        [ForeignKey("Floor")]
        public string FloorId { get; set; }
        [Required]
        [ForeignKey("Room")]
        public string RoomId { get; set; }

        public virtual Building Building { get; private set; }      
            public virtual Block Block { get; private set; }
        public virtual Floor Floor { get; private set; }

        public virtual Room Room{ get; private set; }

        [Range(1, 50, ErrorMessage = "No of People Must be > 0")]
        public int NewAllocation { get; set; }
        public int MaxCapacity { get; set; }

        public int RemainingCapacity { get; set; }

        public int Allocated { get; set; }

    }
}