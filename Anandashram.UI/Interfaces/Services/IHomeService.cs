namespace Anandashram.Interfaces.Services
{
    public interface IHomeService
    {
        HomeDTO GetHomeData();
        DashboardChartDTO GetDashBoardChartForCheckInCheckOut();
    }
}
