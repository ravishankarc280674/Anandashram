namespace Anandashram.Interfaces;
public interface IHome
{
    HomeDTO GetHomeData();
    DashboardChartDTO GetDashBoardChartForCheckInCheckOut();
}
