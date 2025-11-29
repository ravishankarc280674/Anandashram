namespace Anandashram.Services;

public class HomeService : IHomeService
{
    private readonly IHome _homeRepo; // for connecting to efcore.
    public HomeService(IHome homeRepo) // will be passed by dependency injection.
    {
        _homeRepo = homeRepo;
    }
    public DashboardChartDTO GetDashBoardChartForCheckInCheckOut()
    {
        return _homeRepo.GetDashBoardChartForCheckInCheckOut(); 
    }

    public HomeDTO GetHomeData()
    {
        return _homeRepo.GetHomeData(); 
    }
}
