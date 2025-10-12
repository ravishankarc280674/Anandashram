using System.Runtime.InteropServices;

namespace Anandashram.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Devotee")]
        public int DevoteeId { get; set; }
        public virtual Devotee Devotee { get; set; }

        [ForeignKey("Room")]
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }

        [NotMapped]
        public int Remaining { get; set; }

        public int Allocated { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FromDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ToDate { get; set; }

        public bool Closed { get; set; }

        public string CreatedBy { get; set; } = null!;

        public string? ModifiedBy { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ModifiedDate { get; set; }
    }
}