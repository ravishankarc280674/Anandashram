namespace Anandashram.DTO
{
    public class ReservationReportDTO
    {
        public int Id { get; set; }
        public int DevoteeId { get; set; }
        public int RoomId { get; set; }
        public string DevoteeCode { get; set; } = string.Empty;
        public string DevoteeName { get; set; } = string.Empty;
        public string DevoteeCategoryName { get; set; } = string.Empty;
        public DateTime FromDate { get; set; }
        public int Allocated { get; set; }
        public bool Closed { get; set; }
    }
}
