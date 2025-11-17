namespace Anandashram.Interfaces
{
    public interface IHome
    {
        Task<HomeDTO> GetHomeDataAsync();
    }
}
