namespace Anandashram.DTO
{
    public class RoomDTO
    {
        public string Name { get; set; } = string.Empty;
        public string BuildingName { get; set; } = string.Empty;
        public string BlockName { get; set; } = string.Empty;
        public string FloorName { get; set; } = string.Empty;
        public int Occupied { get; set; }
        public int Capacity { get; set; }
        public int RemainingCount { get; set; }
    }
}
