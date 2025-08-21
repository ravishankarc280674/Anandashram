using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN res_partner_category AND res_partner
/// </summary>
public partial class ResPartnerResPartnerCategoryRel
{
    public int CategoryId { get; set; }

    public int PartnerId { get; set; }

    public virtual ResPartnerCategory Category { get; set; } = null!;

    public virtual ResPartner Partner { get; set; } = null!;
}
