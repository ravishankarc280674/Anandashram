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
        [NotMapped]
        public string DevoteeName
        {
            get { if (Devotee != null) return this.Devotee.Name; else return string.Empty; }
        }
        [NotMapped]
        public string DevoteeCode
        {
            get { if (Devotee != null) return this.Devotee.Code; else return string.Empty; }
        }
        [NotMapped]
        public string RoomName
        {
            get { if (Room != null) return this.Room.Name; else return string.Empty; }
        }
        [NotMapped]
        public string BuildingName
        {
            get { if (Room != null) return this.Room.BuildingName; else return string.Empty; }
        }
        [NotMapped]
        public string BlockName
        {
            get { if (Room != null) return this.Room.BlockName; else return string.Empty; }
        }
        [NotMapped]
        public string FloorName
        {
            get { if (Room != null) return this.Room.FloorName; else return string.Empty; }
        }

    }
}