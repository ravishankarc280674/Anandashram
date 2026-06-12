namespace Anandashram.DTO;

public class CFormDTO
{
    public int DevoteeId { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Sex { get; set; }
    public DateTime? DOB { get; set; }

    public string SpecialCategory { get; set; }
    public string Nationality { get; set; }

    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public string ReferenceAddress { get; set; }
    public string ReferenceState { get; set; }
    public string ReferenceCity { get; set; }
    public string ReferencePincode { get; set; }

    public string PassportNo { get; set; }
    public DateTime? PassportDateOfIssue { get; set; }
    public DateTime? PassportDateOfExpiry { get; set; }

    public string VisaNumber { get; set; }
    public string VisaCity { get; set; }
    public string VisaCountry { get; set; }
    public DateTime? VisaDateOfIssue { get; set; }
    public DateTime? VisaDateOfExpiry { get; set; }
    public string VisaType { get; set; }
    public string VisaSubType { get; set; }

    public string ArrivedFromCountry { get; set; }
    public string ArrivedFromCity { get; set; }
    public DateTime? DateOfArrivalInIndia { get; set; }
    public string ArrivedFromPlaceInIndia { get; set; }
    public DateTime? DateOfArrivalInAnandAshram { get; set; }
    public TimeSpan? TimeOfArrivalInAnandAshram { get; set; }
    public int? DurationOfStay { get; set; }

    public bool? IsEmployedInIndia { get; set; }
    public string PurposeOfVisit { get; set; }
    public string NextDestination { get; set; }

    public string DestinationCountry { get; set; }
    public string DestinationState { get; set; }
    public string DestinationCity { get; set; }
    public string Place { get; set; }

    public string ContactPhoneNumber { get; set; }
    public string MobileNumber { get; set; }

    public string PermanentCountryPhone { get; set; }
    public string PermanentCountryMobile { get; set; }

    public string Remarks { get; set; }

    public byte[] PhotoBytes { get; set; }
}
