using System.ComponentModel.DataAnnotations;

namespace Anandashram.UI.Tools.Core.Enums;
public enum SexTypeEnum
{
    [Display(Name = "Male")]
    Male = 1,

    [Display(Name = "Female")]
    Female = 2,

    [Display(Name = "Transgender")]
    Transgender = 3
}
public enum SpecialCategoryTypeEnum
{
    [Display(Name = "OCI")]
    OCI = 1,

    [Display(Name = "PIO")]
    PIO = 2,

    [Display(Name = "General")]
    General = 3
}

public enum NextDestinationTypeEnum
{
    [Display(Name = "India")]
    India = 1,

    [Display(Name = "Outside India")]
    Outside = 2
}