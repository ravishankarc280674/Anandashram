namespace Anandashram.Interfaces;
public interface IBuilding
{
    Task<PaginatedList<Building>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
    Task<Building> GetBuilding(int id); // read particular item

    Task<Building> Create(Building building);

    Task<Building> Edit(Building building);

    Task<Building> Delete(Building building);

    bool IsBuildingNameExists(string name);
    bool IsBuildingNameExists(string name, int Id);
    IEnumerable<Building> GetBuildings();
}
