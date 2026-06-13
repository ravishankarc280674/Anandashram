using DocumentFormat.OpenXml.Math;

namespace Anandashram.Repository;

public class CFormRepository : ICForm
{
    private readonly ApplicationDbContext _context; // for connecting to efcore.
    private readonly IFileManagement _fileManagement; // for connecting to efcore.

    public CFormRepository(ApplicationDbContext context, IFileManagement fileManagement) // will be passed by dependency injection.
    {
        _context = context;
        _fileManagement = fileManagement;
    }
    public async Task<Devotee?> GetDevoteeAsync(int devoteeId)
        => await _context.Devotees.FirstOrDefaultAsync(x => x.Id == devoteeId);
    public async Task<CForm?> GetByDevoteeIdAsync(int devoteeId)
        => await _context.CForms.FirstOrDefaultAsync(x => x.DevoteeId == devoteeId);
    
    public async Task<CForm> SaveAsync(CForm model)
    {
        var existing = await _context.CForms
            .FirstOrDefaultAsync(x => x.DevoteeId == model.DevoteeId);

        if (existing == null)
        {
            await _context.CForms.AddAsync(model);
        }
        else
        {
            // Preserve existing record identity
            model.Id = existing.Id;

            _context.Entry(existing).CurrentValues.SetValues(model);
        }

        await _context.SaveChangesAsync();

        return model;
    }

    public async Task<CFormDTO> GetCFormForPrint(int devoteeId,string devoteeCode)
    {
       var cFormModel= await _context.CForms.FirstOrDefaultAsync(x => x.DevoteeId == devoteeId);
        if (cFormModel == null)
            return null;
        var cFormDTO = new CFormDTO()
        {
            Address = cFormModel.Address,
            ArrivedFromCity = cFormModel.ArrivedFromCity,
            ArrivedFromCountry = cFormModel.ArrivedFromCountry,
            ArrivedFromPlaceInIndia = cFormModel.ArrivedFromPlaceInIndia,
            City = cFormModel.City,
            ContactPhoneNumber = cFormModel.ContactPhoneNumber,
            Country = cFormModel.Country,
            DateOfArrivalInAnandAshram = cFormModel.DateOfArrivalInAnandAshram?.ToString("dd-MMM-yyyy"),
            DateOfArrivalInIndia = cFormModel.DateOfArrivalInIndia?.ToString("dd-MMM-yyyy"),
            DestinationCity = cFormModel.DestinationCity,
            DestinationCountry = cFormModel.DestinationCountry,
            DestinationState = cFormModel.DestinationState,
            DevoteeId = devoteeId,
            DOB = cFormModel.DOB?.ToString("dd-MMM-yyyy"),
            DurationOfStay = cFormModel.DurationOfStay,
            FirstName = cFormModel.FirstName,
            IsEmployedInIndia = cFormModel.IsEmployedInIndia switch
            {
                true => "Yes",
                false => "No",
                null => ""
            },
            LastName = cFormModel.LastName,
            MobileNumber = cFormModel.MobileNumber,
            Nationality = cFormModel.Nationality,
            NextDestination = cFormModel.NextDestination?.ToString() ?? "",
            PassportDateOfExpiry = cFormModel.PassportDateOfExpiry?.ToString("dd-MMM-yyyy"),
            PassportDateOfIssue = cFormModel.PassportDateOfIssue?.ToString("dd-MMM-yyyy"),
            PassportNo = cFormModel.PassportNo,
            PermanentCountryMobile = cFormModel.PermanentCountryMobile,
            PermanentCountryPhone = cFormModel.PermanentCountryPhone,
            Place = cFormModel.Place,
            PurposeOfVisit = cFormModel.PurposeOfVisit,
            ReferenceAddress= cFormModel.ReferenceAddress,
            ReferenceCity= cFormModel.ReferenceCity,
            ReferencePincode= cFormModel.ReferencePincode,
            ReferenceState= cFormModel.ReferenceState,
            Remarks= cFormModel.Remarks,
            Sex = cFormModel.Sex?.ToString() ?? "",
            SpecialCategory = cFormModel.SpecialCategory?.ToString() ?? "",
            TimeOfArrivalInAnandAshram = cFormModel.TimeOfArrivalInAnandAshram.HasValue ? DateTime.Today
            .Add(cFormModel.TimeOfArrivalInAnandAshram.Value)
            .ToString("hh:mm tt") : "",
            VisaCity= cFormModel.VisaCity,
            VisaCountry = cFormModel.VisaCountry,
            VisaDateOfExpiry = cFormModel.VisaDateOfExpiry?.ToString("dd-MMM-yyyy"),
            VisaDateOfIssue = cFormModel.VisaDateOfIssue?.ToString("dd-MMM-yyyy"),
            VisaNumber = cFormModel.VisaNumber,
            VisaSubType = cFormModel.VisaSubType,
            VisaType= cFormModel.VisaType
        };
        cFormDTO.PhotoBytes = await _fileManagement.GetProfilePic(devoteeCode); ;
        return cFormDTO;
    }
}
