using Anandashram.UI.Tools.Core.Enums;
namespace Anandashram.Models;
public class CForm
{
    public int Id { get; set; }

    [Required]
    public int DevoteeId { get; set; }

    public Devotee Devotee { get; set; }

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; }

    [StringLength(100)]
    public string LastName { get; set; }

    public SexTypeEnum? Sex { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DOB { get; set; }

    public SpecialCategoryTypeEnum? SpecialCategory { get; set; }
    public string Nationality { get; set; }

    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string ReferenceAddress { get; set; }
    public string ReferenceState { get; set; }
    public string ReferenceCity { get; set; }
    public string ReferencePincode { get; set; }
    public string PassportNo { get; set; }
    [DataType(DataType.Date)]
    public DateTime? PassportDateOfIssue { get; set; }
    [DataType(DataType.Date)]
    public DateTime? PassportDateOfExpiry { get; set; }
    public string VisaNumber { get; set; }
    public string VisaCity { get; set; }
    public string VisaCountry { get; set; }
    [DataType(DataType.Date)]
    public DateTime? VisaDateOfIssue { get; set; }
    [DataType(DataType.Date)]
    public DateTime? VisaDateOfExpiry { get; set; }
    public string VisaType { get; set; }
    public string VisaSubType { get; set; }
    public string ArrivedFromCountry { get; set; }
    public string ArrivedFromCity { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DateOfArrivalInIndia { get; set; }
    public string ArrivedFromPlaceInIndia { get; set; }
    [DataType(DataType.Date)]
    public DateTime? DateOfArrivalInAnandAshram { get; set; }
    [DataType(DataType.Time)]
    public TimeSpan? TimeOfArrivalInAnandAshram { get; set; }
    public int? DurationOfStay { get; set; }
    public bool? IsEmployedInIndia { get; set; }
    public string PurposeOfVisit { get; set; }
    public NextDestinationTypeEnum? NextDestination { get; set; }
    public string DestinationCountry { get; set; }
    public string DestinationState { get; set; }
    public string DestinationCity { get; set; }
    public string Place { get; set; }
    public string ContactPhoneNumber { get; set; }
    public string MobileNumber { get; set; }
    public string PermanentCountryPhone { get; set; }
    public string PermanentCountryMobile { get; set; }
    public string Remarks { get; set; }
  
    [NotMapped]
    public int? SexValue => (int?)Sex;

    [NotMapped]
    public int? SpecialCategoryValue => (int?)SpecialCategory;

    [NotMapped]
    public int? NextDestinationValue => (int?)NextDestination;
}