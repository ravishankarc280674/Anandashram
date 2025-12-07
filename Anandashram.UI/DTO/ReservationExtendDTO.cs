namespace Anandashram.DTO
{
    public class ReservationExtendDTO
    {
        public int CurrentRoomId { get; set; }
        public string ToDate { get; set; }
        public List<RoomDTO> Rooms { get; set; }
        public int Allocated { get; set; }
    }
}
