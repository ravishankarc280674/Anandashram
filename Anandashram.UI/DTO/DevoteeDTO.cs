namespace Anandashram.DTO;
public partial class DevoteeDTO
{
    public DevoteeDTO()
    {
    }
    public string Code { get;set; }

    public string Name { get; set; } = null!;
    public string Mobile { get; set; } = null!;
   
    public string Email { get; set; } = null!;
    public string Document { get; set; }
   
    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? State { get; set; }
    public string? Country { get; set; }

    public string? PinCode { get; set; }

    [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
    public DateTime StartDate { get; set; } = DateTime.Now;

    [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
    public DateTime EndDate { get; set; } = DateTime.Now;
    public int NoOfPeople { get; set; }

    public string? DevoteeCategoryName { get; set; }

    public bool Closed { get; set; }

    public string? ReopenedCode { get; set; }
}
