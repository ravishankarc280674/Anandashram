namespace Anandashram.Models;
    public partial class RoomDTO
    {

        public RoomDTO()
        {
            //Reservations = new List<Reservation>();
        }
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; } = null!;
        public int BuildingId { get; set; }
        public int BlockId { get; set; }
        public int FloorId { get; set; }
        public int Capacity { get; set; }
        public string BuildingName { get; set; }
        public string BlockName { get; set; }
        public string FloorName { get; set; }
    }
