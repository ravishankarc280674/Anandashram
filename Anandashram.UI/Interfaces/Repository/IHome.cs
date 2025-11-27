namespace Anandashram.Interfaces.Repository;
public interface IHome
{
    HomeDTO GetHomeData();
    DashboardChartDTO GetDashBoardChartForCheckInCheckOut();
}
