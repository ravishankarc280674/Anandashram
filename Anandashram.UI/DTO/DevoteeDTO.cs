namespace Anandashram.DTO;
internal class DevoteeDTO
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string DevoteeCategoryName { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string State { get; set; }
    public string PinCode { get; set; }
    public string Country { get; set; }
    public string Document { get; set; }
    public int NoOfPeople { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}