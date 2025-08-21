using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN res_country AND res_country_group
/// </summary>
public partial class ResCountryResCountryGroupRel
{
    public int ResCountryId { get; set; }

    public int ResCountryGroupId { get; set; }

    public virtual ResCountry ResCountry { get; set; } = null!;

    public virtual ResCountryGroup ResCountryGroup { get; set; } = null!;
}
