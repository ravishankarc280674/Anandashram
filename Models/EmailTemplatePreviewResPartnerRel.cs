using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN email_template_preview AND res_partner
/// </summary>
public partial class EmailTemplatePreviewResPartnerRel
{
    public int EmailTemplatePreviewId { get; set; }

    public int ResPartnerId { get; set; }

    public virtual EmailTemplatePreview EmailTemplatePreview { get; set; } = null!;

    public virtual ResPartner ResPartner { get; set; } = null!;
}
