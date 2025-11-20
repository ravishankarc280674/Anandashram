namespace Anandashram.DTO;
public class HomeDTO
{
    public int TotalDevoteesCount { get; set; }
    public int TotalActiveDevotees { get; set; }
    public int TotalRoomCapacity { get; set; }
    public int TotalRoomCapacityAvailable { get; set; }
    public int TodaysCheckIns { get; set; }
    public int TodaysCheckOuts { get; set; }

    public DashboardChartDTO ChartDTO { get; set; }
}
