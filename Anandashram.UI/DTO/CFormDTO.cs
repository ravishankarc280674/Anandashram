namespace Anandashram.DTO;

public class CFormDTO
{
    public int DevoteeId { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Sex { get; set; }
    public string DOB { get; set; }

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
    public string PassportIssueCity { get; set; }
    public string PassportIssueCountry { get; set; }
    public string PassportDateOfIssue { get; set; }
    public string PassportDateOfExpiry { get; set; }

    public string VisaNumber { get; set; }
    public string VisaCity { get; set; }
    public string VisaCountry { get; set; }
    public string VisaDateOfIssue { get; set; }
    public string VisaDateOfExpiry { get; set; }
    public string VisaType { get; set; }
    public string VisaSubType { get; set; }

    public string ArrivedFromCountry { get; set; }
    public string ArrivedFromCity { get; set; }
    public string DateOfArrivalInIndia { get; set; }
    public string ArrivedFromPlaceInIndia { get; set; }
    public string DateOfArrivalInAnandAshram { get; set; }
    public string TimeOfArrivalInAnandAshram { get; set; }
    public int? DurationOfStay { get; set; }

    public string IsEmployedInIndia { get; set; }
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
